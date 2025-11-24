using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	/// <summary>
	/// 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct BNNameSpace
	{
		/// <summary>
		/// 
		/// const char** name
		/// </summary>
		internal IntPtr name;

		/// <summary>
		/// 
		/// const char* join
		/// </summary>
		internal IntPtr join;
		
		/// <summary>
		/// 
		/// uint64_t nameCount
		/// </summary>
		internal ulong nameCount;
	}
	
    public sealed class NameSpace : INativeWrapperEx<BNNameSpace>
    {
		public string[] Name { get; set; } = Array.Empty<string>();
		
		public string Join { get; set; } = "";
		
		internal NameSpace() 
		{
			
		}
		
		internal static NameSpace MustFromNativePointer(IntPtr rawPtr)
		{
			return NameSpace.FromNative(Marshal.PtrToStructure<BNNameSpace>(rawPtr));
		}
		
		internal static NameSpace FromNative(BNNameSpace native) 
		{
			return new NameSpace()
			{
				Name = UnsafeUtils.ReadAnsiStringArray(native.name , native.nameCount) , 
				Join = UnsafeUtils.ReadAnsiString(native.join)
			};
		}
		
		internal static NameSpace TakeNative(BNNameSpace native) 
		{
			NameSpace target = new NameSpace()
			{
				Name = UnsafeUtils.ReadAnsiStringArray(native.name , native.nameCount) , 
				Join = UnsafeUtils.ReadAnsiString(native.join)
			};

			NativeMethods.BNFreeNameSpace(native);

			return target;
		}
		
		public BNNameSpace ToNativeEx(ScopedAllocator allocator)
		{
			return new BNNameSpace()
			{
				name = allocator.AllocAnsiStringArray(this.Name) ,
				nameCount = (ulong)this.Name.Length,
				join = allocator.AllocAnsiString(this.Join), 
			};
		}

		public static NameSpace Internal()
		{
			return NameSpace.TakeNative(NativeMethods.BNGetInternalNameSpace());
		}
		
		public static NameSpace External()
		{
			return NameSpace.TakeNative(NativeMethods.BNGetExternalNameSpace());
		}
    }
}