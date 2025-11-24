using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNAddressRange 
	{
		/// <summary>
		/// uint64_t start
		/// </summary>
		internal ulong start;
		
		/// <summary>
		/// uint64_t end
		/// </summary>
		internal ulong end;
	}

    public sealed class AddressRange 
    {
		public ulong Start { get; set; } = 0;
		
		public ulong End { get; set; } = 0;
		
		public AddressRange() 
		{
			
		}
		
		public AddressRange(ulong start, ulong end) 
		{
		    this.Start = start;
		    this.End = end;
		}
		
		internal static AddressRange FromNative(BNAddressRange raw )
		{
			return new AddressRange(
				raw.start ,
				raw.end
			);
		}
    }
}