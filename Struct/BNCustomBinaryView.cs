using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct BNCustomBinaryView 
	{
		// bool (*init)(void* ctxt);
	    [UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
	    internal unsafe delegate bool InitDelegate(
		    IntPtr ctxt
	    );
	    
	    // void (*freeObject)(void* ctxt);
	    [UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
	    internal unsafe delegate void FreeObjectDelegate(
		    IntPtr ctxt
	    );
	    
	    // void (*externalRefTaken)(void* ctxt);
	    [UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
	    internal unsafe delegate void ExternalRefTakenDelegate(
		    IntPtr ctxt
	    );
	    
	    // void (*externalRefReleased)(void* ctxt);
	    [UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
	    internal unsafe delegate void ExternalRefReleasedDelegate(
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
		    IntPtr src,
		    ulong length
	    );
	    
	    // size_t (*insert)(void* ctxt, uint64_t offset, const void* src, size_t len);
	    [UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
	    internal unsafe delegate ulong InsertDelegate(
		    IntPtr ctxt,
		    ulong offset,
		    IntPtr src,
		    ulong length
	    );
	    
	    // size_t (*remove)(void* ctxt, uint64_t offset, uint64_t len);
	    [UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
	    internal unsafe delegate ulong RemoveDelegate(
		    IntPtr ctxt,
		    ulong offset,
		    ulong length
	    );
	    
	    // BNModificationStatus (*getModification)(void* ctxt, uint64_t offset);
	    [UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
	    internal unsafe delegate ModificationStatus GetModificationDelegate(
		    IntPtr ctxt,
		    ulong offset
	    );
	    
	    // bool (*isValidOffset)(void* ctxt, uint64_t offset);
	    [UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
	    internal unsafe delegate bool IsValidOffsetDelegate(
		    IntPtr ctxt ,
		    ulong offset
	    );
	    
	    // bool (*isOffsetReadable)(void* ctxt, uint64_t offset);
	    [UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
	    internal unsafe delegate bool IsOffsetReadableDelegate(
		    IntPtr ctxt ,
		    ulong offset
	    );
	    
	    // bool (*isOffsetWritable)(void* ctxt, uint64_t offset);
	    [UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
	    internal unsafe delegate bool IsOffsetWritableDelegate(
		    IntPtr ctxt,
		    ulong offset
	    );
	    
	    // bool (*isOffsetExecutable)(void* ctxt, uint64_t offset);
	    [UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
	    internal unsafe delegate bool IsOffsetExecutableDelegate(
		    IntPtr ctxt,
		    ulong offset
	    );
	    
	    // bool (*isOffsetBackedByFile)(void* ctxt, uint64_t offset);
	    [UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
	    internal unsafe delegate bool IsOffsetBackedByFileDelegate(
		    IntPtr ctxt,
		    ulong offset
	    );
	    
	    // uint64_t (*getNextValidOffset)(void* ctxt, uint64_t offset);
	    [UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
	    internal unsafe delegate ulong GetNextValidOffsetDelegate(
		    IntPtr ctxt,
		    ulong offset
	    );
	    
	    // uint64_t (*getStart)(void* ctxt);
	    [UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
	    internal unsafe delegate ulong GetStartDelegate(
		    IntPtr ctxt
	    );
	    
	    
	    // uint64_t (*getLength)(void* ctxt);
	    [UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
	    internal unsafe delegate ulong GetLengthDelegate(
		    IntPtr ctxt
	    );
	    
	    // uint64_t (*getEntryPoint)(void* ctxt);
	    [UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
	    internal unsafe delegate ulong GetEntryPointDelegate(
		    IntPtr ctxt
	    );
	    
	    // bool (*isExecutable)(void* ctxt);
	    [UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
	    internal unsafe delegate bool IsExecutableDelegate(
		    IntPtr ctxt
	    );
	    
	    // BNEndianness (*getDefaultEndianness)(void* ctxt);
	    [UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
	    internal unsafe delegate Endianness GetDefaultEndiannessDelegate(
		    IntPtr ctxt
	    );
	    
	    // bool (*isRelocatable)(void* ctxt);
	    [UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
	    internal unsafe delegate bool IsRelocatableDelegate(
		    IntPtr ctxt
	    );
	    
	    // size_t (*getAddressSize)(void* ctxt);
	    [UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
	    internal unsafe delegate ulong GetAddressSizeDelegate(
		    IntPtr ctxt
	    );
	    
	    // bool (*save)(void* ctxt, BNFileAccessor* accessor);
	    [UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
	    internal unsafe delegate bool SaveDelegate(
		    IntPtr ctxt,
		    IntPtr accessor
	    );
	    
		/// <summary>
		/// void* context
		/// </summary>
		internal IntPtr context;
		
		/// <summary>
		/// void* init
		/// </summary>
		internal IntPtr init;
		
		/// <summary>
		/// void* freeObject
		/// </summary>
		internal IntPtr freeObject;
		
		/// <summary>
		/// void* externalRefTaken
		/// </summary>
		internal IntPtr externalRefTaken;
		
		/// <summary>
		/// void* externalRefReleased
		/// </summary>
		internal IntPtr externalRefReleased;
		
		/// <summary>
		/// void* read
		/// </summary>
		internal IntPtr read;
		
		/// <summary>
		/// void* write
		/// </summary>
		internal IntPtr write;
		
		/// <summary>
		/// void* insert
		/// </summary>
		internal IntPtr insert;
		
		/// <summary>
		/// void* remove
		/// </summary>
		internal IntPtr remove;
		
		/// <summary>
		/// void* getModification
		/// </summary>
		internal IntPtr getModification;
		
		/// <summary>
		/// void* isValidOffset
		/// </summary>
		internal IntPtr isValidOffset;
		
		/// <summary>
		/// void* isOffsetReadable
		/// </summary>
		internal IntPtr isOffsetReadable;
		
		/// <summary>
		/// void* isOffsetWritable
		/// </summary>
		internal IntPtr isOffsetWritable;
		
		/// <summary>
		/// void* isOffsetExecutable
		/// </summary>
		internal IntPtr isOffsetExecutable;
		
		/// <summary>
		/// void* isOffsetBackedByFile
		/// </summary>
		internal IntPtr isOffsetBackedByFile;
		
		/// <summary>
		/// void* getNextValidOffset
		/// </summary>
		internal IntPtr getNextValidOffset;
		
		/// <summary>
		/// void* getStart
		/// </summary>
		internal IntPtr getStart;
		
		/// <summary>
		/// void* getLength
		/// </summary>
		internal IntPtr getLength;
		
		/// <summary>
		/// void* getEntryPoint
		/// </summary>
		internal IntPtr getEntryPoint;
		
		/// <summary>
		/// void* isExecutable
		/// </summary>
		internal IntPtr isExecutable;
		
		/// <summary>
		/// void* getDefaultEndianness
		/// </summary>
		internal IntPtr getDefaultEndianness;
		
		/// <summary>
		/// void* isRelocatable
		/// </summary>
		internal IntPtr isRelocatable;
		
		/// <summary>
		/// void* getAddressSize
		/// </summary>
		internal IntPtr getAddressSize;
		
		/// <summary>
		/// void* save
		/// </summary>
		internal IntPtr save;
	}

    public abstract class CustomBinaryView 
    {
		public CustomBinaryView() 
		{
			
		}

		public BNCustomBinaryView ToNative()
		{
			return new BNCustomBinaryView
			{
				context = IntPtr.Zero,
				init = Marshal.GetFunctionPointerForDelegate<BNCustomBinaryView.InitDelegate>(this.InitThunk),
				freeObject = Marshal.GetFunctionPointerForDelegate<BNCustomBinaryView.FreeObjectDelegate>(this.FreeObjectThunk),
				externalRefTaken = Marshal.GetFunctionPointerForDelegate<BNCustomBinaryView.ExternalRefTakenDelegate>(this.ExternalRefTakenThunk),
				externalRefReleased = Marshal.GetFunctionPointerForDelegate<BNCustomBinaryView.ExternalRefReleasedDelegate>(this.ExternalRefReleasedThunk),
				read = Marshal.GetFunctionPointerForDelegate<BNCustomBinaryView.ReadDelegate>(this.ReadThunk),
				write = Marshal.GetFunctionPointerForDelegate<BNCustomBinaryView.WriteDelegate>(this.WriteThunk),
				insert = Marshal.GetFunctionPointerForDelegate<BNCustomBinaryView.InsertDelegate>(this.InsertThunk),
				remove = Marshal.GetFunctionPointerForDelegate<BNCustomBinaryView.RemoveDelegate>(this.RemoveThunk),
				getModification = Marshal.GetFunctionPointerForDelegate<BNCustomBinaryView.GetModificationDelegate>(this.GetModificationThunk),
				isValidOffset = Marshal.GetFunctionPointerForDelegate<BNCustomBinaryView.IsValidOffsetDelegate>(this.IsValidOffsetThunk),
				isOffsetReadable = Marshal.GetFunctionPointerForDelegate<BNCustomBinaryView.IsOffsetReadableDelegate>(this.IsOffsetReadableThunk),
				isOffsetWritable = Marshal.GetFunctionPointerForDelegate<BNCustomBinaryView.IsOffsetWritableDelegate>(this.IsOffsetWritableThunk),
				isOffsetExecutable = Marshal.GetFunctionPointerForDelegate<BNCustomBinaryView.IsOffsetExecutableDelegate>(this.IsOffsetExecutableThunk),
				isOffsetBackedByFile = Marshal.GetFunctionPointerForDelegate<BNCustomBinaryView.IsOffsetBackedByFileDelegate>(this.IsOffsetBackedByFileThunk),
				getNextValidOffset = Marshal.GetFunctionPointerForDelegate<BNCustomBinaryView.GetNextValidOffsetDelegate>(this.GetNextValidOffsetThunk),
				getStart = Marshal.GetFunctionPointerForDelegate<BNCustomBinaryView.GetStartDelegate>(this.GetStartThunk),
				getLength = Marshal.GetFunctionPointerForDelegate<BNCustomBinaryView.GetLengthDelegate>(this.GetLengthThunk),
				getEntryPoint = Marshal.GetFunctionPointerForDelegate<BNCustomBinaryView.GetEntryPointDelegate>(this.GetEntryPointThunk),
				isExecutable = Marshal.GetFunctionPointerForDelegate<BNCustomBinaryView.IsExecutableDelegate>(this.IsExecutableThunk),
				getDefaultEndianness = Marshal.GetFunctionPointerForDelegate<BNCustomBinaryView.GetDefaultEndiannessDelegate>(this.GetDefaultEndiannessThunk),
				isRelocatable = Marshal.GetFunctionPointerForDelegate<BNCustomBinaryView.IsRelocatableDelegate>(this.IsRelocatableThunk),
				getAddressSize = Marshal.GetFunctionPointerForDelegate<BNCustomBinaryView.GetAddressSizeDelegate>(this.GetAddressSizeThunk),
				save = Marshal.GetFunctionPointerForDelegate<BNCustomBinaryView.SaveDelegate>(this.SaveThunk),
			};
		}
		
		public BinaryView? CreateView(
			string  name,
			BinaryView parent ,
			FileMetadata? file = null
		)
		{
			if (null == file)
			{
				file = parent.File;
			}

			return BinaryView.TakeHandle(
				NativeMethods.BNCreateCustomBinaryView(
					name ,
					file.DangerousGetHandle() ,
					parent.DangerousGetHandle() ,
					this.ToNative()
				)
			);
		}
		
		#region Thunk
	
		// bool (*init)(void* ctxt);
	    private bool InitThunk(IntPtr ctxt)
	    {
		    return this.Init();
	    }
	    
	    // void (*freeObject)(void* ctxt);
	    private void FreeObjectThunk(IntPtr ctxt)
	    {
		    this.FreeObject();
	    }
	    
	    
	    // void (*externalRefTaken)(void* ctxt);
	    private void ExternalRefTakenThunk(IntPtr ctxt)
	    {
		    this.ExternalRefTaken();
	    }
	    
	    // void (*externalRefReleased)(void* ctxt);
	    private void ExternalRefReleasedThunk(IntPtr ctxt)
	    {
		   this.ExternalRefReleased();
	    }
	    
	    // size_t (*read)(void* ctxt, void* dest, uint64_t offset, size_t len);
	    private ulong ReadThunk(
		    IntPtr ctxt ,
		    IntPtr dest ,
		    ulong offset ,
		    ulong length
	    )
	    {
		    if (0 == length)
		    {
			    return 0;
		    }
		    
		    byte[] data = this.Read(offset, length);

		    if (0 != data.Length)
		    {
			    Marshal.Copy(data, 0, dest, data.Length);
		    }
		    
		    return (ulong)data.Length;
	    }
	    
	    // size_t (*write)(void* ctxt, uint64_t offset, const void* src, size_t len);
	    private ulong WriteThunk(
		    IntPtr ctxt ,
		    ulong offset ,
		    IntPtr src ,
		    ulong length
	    )
	    {
		    if (0 == length)
		    {
			    return 0;
		    }
		    
		    byte[] data = new byte[length];
		    
		    Marshal.Copy(src , data ,0, data.Length);
		    
		    return (ulong)this.Write(offset, data);
	    }
	    
	    // size_t (*insert)(void* ctxt, uint64_t offset, const void* src, size_t len);
	    private ulong InsertThunk(
		    IntPtr ctxt ,
		    ulong offset ,
		    IntPtr src ,
		    ulong length
	    )
	    {
		    if (0 == length)
		    {
			    return 0;
		    }
		    
		    byte[] data = new byte[length];
		    
		    Marshal.Copy(src , data ,0, data.Length);
		    
		    return (ulong)this.Insert(offset, data);
	    }
	    
	    // size_t (*remove)(void* ctxt, uint64_t offset, uint64_t len);
	    private ulong RemoveThunk(
		    IntPtr ctxt ,
		    ulong offset ,
		    ulong length
	    )
	    {
		    return this.Remove(offset, length);
	    }
	    
	    // BNModificationStatus (*getModification)(void* ctxt, uint64_t offset);
	    private ModificationStatus GetModificationThunk(
		    IntPtr ctxt ,
		    ulong offset
	    )
	    {
		    return this.GetModification(offset);
	    }
	    
	    // bool (*isValidOffset)(void* ctxt, uint64_t offset);
	    private bool IsValidOffsetThunk(
		    IntPtr ctxt ,
		    ulong offset
	    )
	    {
		    return this.IsValidOffset(offset);
	    }
	    
	    // bool (*isOffsetReadable)(void* ctxt, uint64_t offset);
	    private bool IsOffsetReadableThunk(
		    IntPtr ctxt ,
		    ulong offset
	    )
	    {
		    return this.IsOffsetReadable(offset);
	    }
	    
	    // bool (*isOffsetWritable)(void* ctxt, uint64_t offset);
	    private bool IsOffsetWritableThunk(
		    IntPtr ctxt ,
		    ulong offset
	    )
	    {
		    return this.IsOffsetWritable(offset);
	    }
	    
	    // bool (*isOffsetExecutable)(void* ctxt, uint64_t offset);
	    private bool IsOffsetExecutableThunk(
		    IntPtr ctxt ,
		    ulong offset
	    )
	    {
		    return this.IsOffsetExecutable(offset);
	    }
	    
	    // bool (*isOffsetBackedByFile)(void* ctxt, uint64_t offset);
	    private bool IsOffsetBackedByFileThunk(
		    IntPtr ctxt ,
		    ulong offset
	    )
	    {
		    return this.IsOffsetBackedByFile(offset);
	    }
	    
	    // uint64_t (*getNextValidOffset)(void* ctxt, uint64_t offset);
	    private ulong GetNextValidOffsetThunk(
		    IntPtr ctxt ,
		    ulong offset
	    )
	    {
		    return this.GetNextValidOffset(offset);
	    }
	    
	    // uint64_t (*getStart)(void* ctxt);
	    private ulong GetStartThunk(IntPtr ctxt)
	    {
		    return this.Start;
	    }
	    
	    
	    // uint64_t (*getLength)(void* ctxt);
	    private ulong GetLengthThunk(IntPtr ctxt)
	    {
		    return this.Length;
	    }
	    
	    // uint64_t (*getEntryPoint)(void* ctxt);
	    private ulong GetEntryPointThunk(IntPtr ctxt)
	    {
		    return this.EntryPoint;
	    }
	    
	    // bool (*isExecutable)(void* ctxt);
	    private bool IsExecutableThunk(IntPtr ctxt)
	    {
		    return this.Executable;
	    }
	    
	    // BNEndianness (*getDefaultEndianness)(void* ctxt);
	    private Endianness GetDefaultEndiannessThunk(IntPtr ctxt)
	    {
		    return this.DefaultEndianness;
	    }
	    
	    // bool (*isRelocatable)(void* ctxt);
	    private bool IsRelocatableThunk(IntPtr ctxt)
	    {
		    return this.Relocatable;
	    }
	    
	    // size_t (*getAddressSize)(void* ctxt);
	    private ulong GetAddressSizeThunk(IntPtr ctxt)
	    {
		    return this.AddressSize;
	    }
	    
	    // bool (*save)(void* ctxt, BNFileAccessor* accessor);
	    private bool SaveThunk(IntPtr ctxt , IntPtr accessor)
	    {
		    return this.Save(
			    FileAccessor.MustFromNativePointer(accessor)
			);
	    }
	    
	    #endregion Thunk

	    #region methods

	    public virtual bool Init()
	    {
		    return true;
	    }

	    public virtual void FreeObject()
	    {
		    
	    }
	    
	    public virtual void ExternalRefTaken()
	    {
		    
	    }
	    
	    public virtual void ExternalRefReleased()
	    {
		   
	    }
	    

	    public virtual byte[] Read(ulong offset , ulong length)
	    {
		    return Array.Empty<byte>();
	    }
	    
	    public virtual int Write(ulong offset , byte[] data)
	    {
		    return 0;
	    }
	    
	    public virtual int Insert(ulong offset , byte[] data)
	    {
		    return 0;
	    }
	    
	    public virtual ulong Remove(ulong offset , ulong length)
	    {
		    return 0;
	    }
	    
	    public virtual ModificationStatus GetModification(ulong offset)
	    {
		    return ModificationStatus.Original;
	    }
	    
	    public virtual bool IsValidOffset(ulong offset)
	    {
		    return false;
	    }
	    
	    public virtual bool IsOffsetReadable(ulong offset)
	    {
		    return false;
	    }
	    
	    public virtual bool IsOffsetWritable(ulong offset)
	    {
		    return false;
	    }
	    
	    public virtual bool IsOffsetExecutable(ulong offset)
	    {
		    return false;
	    }
	    
	    public virtual bool IsOffsetBackedByFile(ulong offset)
	    {
		    return false;
	    }
	    
	    public virtual ulong GetNextValidOffset(ulong offset)
	    {
		    return 0;
	    }
	    
	    public virtual ulong Start
	    {
		    get
		    {
			    return 0;
		    }
	    }
	    
	    public virtual ulong Length
	    {
		    get
		    {
			    return 0;
		    }
	    }
	    
	    public virtual ulong EntryPoint
	    {
		    get
		    {
			    return 0;
		    }
	    }
	    
	    public virtual bool Executable
	    {
		    get
		    {
			    return false;
		    }
	    }
	    
	    public virtual Endianness DefaultEndianness
	    {
		    get
		    {
			    return Endianness.LittleEndian;
		    }
	    }
	    
	    public virtual bool Relocatable
	    {
		    get
		    {
			    return false;
		    }
	    }
	    
	    public virtual ulong AddressSize
	    {
		    get
		    {
			    return 0;
		    }
	    }
	    
	    public virtual bool Save(FileAccessor accessor)
	    {
		    return false;
	    }

	    #endregion methods
    }
}