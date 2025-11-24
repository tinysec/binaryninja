using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct BNLookupTableEntry 
	{
		/// <summary>
		/// int64_t* fromValues
		/// </summary>
		internal IntPtr fromValues;
		
		/// <summary>
		/// uint64_t fromCount
		/// </summary>
		internal ulong fromCount;
		
		/// <summary>
		/// int64_t toValue
		/// </summary>
		internal long toValue;
	}

    public sealed class LookupTableEntry : INativeWrapperEx<BNLookupTableEntry>
    {
		public long[] FromValues { get; set; } = Array.Empty<long>();
		
		public long ToValue { get; set; } = 0;
		
		public LookupTableEntry() 
		{
		    
		}

		internal static LookupTableEntry FromNative(BNLookupTableEntry native)
		{
			return new LookupTableEntry()
			{
				FromValues = UnsafeUtils.ReadNumberArray<long>(
					native.fromValues ,
					native.fromCount
				) ,
				ToValue = native.toValue
			};
		}

		public BNLookupTableEntry ToNativeEx(ScopedAllocator allocator)
		{
			return new BNLookupTableEntry()
			{
				fromValues = ( 
					0 == this.FromValues.Length ? IntPtr.Zero : 
						allocator.AllocIntegerArray<long>(this.FromValues)
					),
				fromCount = (ulong)this.FromValues.Length,
				toValue = this.ToValue
			};
		}
		
    }
}