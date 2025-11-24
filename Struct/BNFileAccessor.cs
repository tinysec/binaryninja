using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct BNFileAccessor 
	{
		// uint64_t (*getLength)(void* ctxt);
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate ulong GetLengthDelegate(
			IntPtr ctxt
		);
		
		// size_t (*read)(void* ctxt, void* dest, uint64_t offset, size_t len);
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate ulong ReadDelegate(
			IntPtr ctxt,
			IntPtr dest,
			ulong offset,
			ulong length
		);
		
		// size_t (*write)(void* ctxt, uint64_t offset, const void* src, size_t len);
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate ulong WriteDelegate(
			IntPtr ctxt,
			ulong offset,
			IntPtr data,
			ulong length
		);
		
		/// <summary>
		/// void* context
		/// </summary>
		internal IntPtr context;
		
		/// <summary>
		/// void** getLength
		/// </summary>
		internal IntPtr getLength;
		
		/// <summary>
		/// void** read
		/// </summary>
		internal IntPtr read;
		
		/// <summary>
		/// void** write
		/// </summary>
		internal IntPtr write;
	}

    public sealed class FileAccessor : INativeWrapper<BNFileAccessor>
    {
	    public delegate ulong GetLengthDelegate();
	    
	    public delegate byte[] ReadDelegate(
		    ulong offset,
		    ulong length
	    );
	    
	    public delegate ulong WriteDelegate(
		    ulong offset,
		    byte[] data
	    );
	    
		public GetLengthDelegate? GetLength { get; set; } = null;
		
		public ReadDelegate? Read { get; set; } = null;

		public WriteDelegate? Write { get; set; } = null;
		
		// bridge
		private BNFileAccessor.GetLengthDelegate? m_getLength = null;
		
		private BNFileAccessor.ReadDelegate? m_read = null;
		
		private BNFileAccessor.WriteDelegate? m_write = null;
		
		public FileAccessor() 
		{
		    
		}

		internal static FileAccessor FromNative(BNFileAccessor native)
		{
			FileAccessor accessor = new FileAccessor();
			
			if (IntPtr.Zero != native.getLength)
			{
				accessor.m_getLength = Marshal.GetDelegateForFunctionPointer<BNFileAccessor.GetLengthDelegate>(
					native.getLength
				);

				accessor.GetLength = accessor.GetLengthBridge;
			}
			
			if (IntPtr.Zero != native.read)
			{
				accessor.m_read = Marshal.GetDelegateForFunctionPointer<BNFileAccessor.ReadDelegate>(
					native.read
				);

				accessor.Read = accessor.ReadBridge;
			}
			
			if (IntPtr.Zero != native.write)
			{
				accessor.m_write = Marshal.GetDelegateForFunctionPointer<BNFileAccessor.WriteDelegate>(
					native.write
				);

				accessor.Write = accessor.WriteBridge;
			}
			
			return accessor;
		}

		internal static FileAccessor MustFromNativePointer(IntPtr pointer)
		{
			if (IntPtr.Zero == pointer)
			{
				throw new NullReferenceException(nameof(pointer));
			}
			
			return FileAccessor.FromNative(Marshal.PtrToStructure<BNFileAccessor>(pointer));
		}

		public BNFileAccessor ToNative()
		{
			return new BNFileAccessor()
			{
				context = IntPtr.Zero ,
				getLength =
					( null == this.m_getLength ? IntPtr.Zero : 
						Marshal.GetFunctionPointerForDelegate<BNFileAccessor.GetLengthDelegate>(this.m_getLength) ) ,
				read = ( null == this.m_read ? IntPtr.Zero 
					: Marshal.GetFunctionPointerForDelegate<BNFileAccessor.ReadDelegate>(this.m_read) ) ,
				write = ( null == this.m_write ? IntPtr.Zero 
					: Marshal.GetFunctionPointerForDelegate<BNFileAccessor.WriteDelegate>(this.m_write) )
			};
		}
		
		private ulong GetLengthBridge()
		{
			if (null == this.m_getLength)
			{
				throw new NullReferenceException();
			}

			// uint64_t (*getLength)(void* ctxt);
			return this.m_getLength(
				IntPtr.Zero
			);
		}
	    
		private byte[] ReadBridge(ulong offset , ulong length)
		{
			if (null == this.m_read)
			{
				throw new NullReferenceException();
			}
			
			byte[] buffer = new byte[length];
			
			
			// size_t (*read)(void* ctxt, void* dest, uint64_t offset, size_t len);

			ulong readed = 0;
			
			unsafe
			{
				fixed (byte* ptrBuffer = buffer)
				{
					readed = this.m_read(
						IntPtr.Zero,
						( IntPtr)ptrBuffer,
						offset,
						length
					);
				}
			}
			
			if (readed < length)
			{
				if (0 == readed)
				{
					return Array.Empty<byte>();
				}
				
				byte[] data = new byte[readed];

				Array.Copy(
					buffer,
					data,
					(int)readed
				);
				
				return data;
			}

			return buffer;
		}
	    
		private ulong WriteBridge(ulong offset , byte[] data)
		{
			if (null == this.m_write)
			{
				throw new NullReferenceException();
			}

			unsafe
			{
				fixed (byte* ptrData = data)
				{
					// size_t (*write)(void* ctxt, uint64_t offset, const void* src, size_t len);
					return this.m_write(
						IntPtr.Zero,
						offset,
						(IntPtr)ptrData,
						(ulong)data.Length
					);
				}
			}
		}
    }
    
    public abstract class CustomFileAccessor : INativeWrapper<BNFileAccessor>
    {
	    public CustomFileAccessor() 
	    {
		    
	    }

	    public BNFileAccessor ToNative()
	    {
		    return new BNFileAccessor()
		    {
			    context = IntPtr.Zero ,
			    getLength = Marshal.GetFunctionPointerForDelegate<BNFileAccessor.GetLengthDelegate>(this.GetLengthThunk) ,
			    read = Marshal.GetFunctionPointerForDelegate<BNFileAccessor.ReadDelegate>(this.ReadThunk) ,
			    write = Marshal.GetFunctionPointerForDelegate<BNFileAccessor.WriteDelegate>(this.WriteThunk) ,
		    };
	    }

	    #region  thunk
		
	    // uint64_t (*getLength)(void* ctxt);
	    private ulong GetLengthThunk(IntPtr ctxt)
	    {
		    return this.GetLength();
	    }
		
	    // size_t (*read)(void* ctxt, void* dest, uint64_t offset, size_t len);
	    private ulong ReadThunk(
		    IntPtr ctxt ,
		    IntPtr dest ,
		    ulong offset ,
		    ulong length
	    )
	    {
		    byte[] data = this.Read(offset, length);
		    
		    Marshal.Copy(
			    data, 
			    0, 
			    dest,
			    data.Length
			);
		    
		    return (ulong)data.Length;
	    }
		
	    // size_t (*write)(void* ctxt, uint64_t offset, const void* src, size_t len);
	    private ulong WriteThunk(
		    IntPtr ctxt ,
		    ulong offset ,
		    IntPtr data ,
		    ulong length
	    )
	    {
		    byte[] buffer = new byte[length];
		    
		    Marshal.Copy(
			    data,
			    buffer,
			    0,
			    (int)length
			);
		    
		    return this.Write(offset, buffer);
	    }
		
	    #endregion thunk
	    
	    #region  methods
	    
	    public virtual ulong GetLength( )
	    {
		    return 0;
	    }
	    
	    public virtual byte[] Read(ulong offset , ulong length)
	    {
		    return Array.Empty<byte>();
	    }
	    
	    public virtual ulong Write(ulong offset , byte[] data)
	    {
		    return 0;
	    }
		
	    #endregion methods
    }
    
}