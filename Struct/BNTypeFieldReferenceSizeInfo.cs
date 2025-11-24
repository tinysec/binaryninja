using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct BNTypeFieldReferenceSizeInfo 
	{
		/// <summary>
		/// uint64_t offset
		/// </summary>
		internal ulong offset;
		
		/// <summary>
		/// uint64_t* sizes
		/// </summary>
		internal IntPtr sizes;
		
		/// <summary>
		/// uint64_t count
		/// </summary>
		internal ulong count;
	}

    public sealed class TypeFieldReferenceSizeInfo 
    {
		public ulong Offset { get; set; } = 0;
		
		public ulong[] Sizes { get; set; } = Array.Empty<ulong>();
		
		public TypeFieldReferenceSizeInfo() 
		{
		    
		}

		internal static TypeFieldReferenceSizeInfo FromNative(BNTypeFieldReferenceSizeInfo native)
		{
			return new TypeFieldReferenceSizeInfo()
			{
				Offset = native.offset , 
				Sizes = UnsafeUtils.ReadNumberArray<ulong>(native.sizes , native.count)
			};
		}
		
    }
}