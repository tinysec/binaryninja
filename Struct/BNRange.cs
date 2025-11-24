using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNRange 
	{
		/// <summary>
		/// uint64_t start
		/// </summary>
		public ulong start;
		
		/// <summary>
		/// uint64_t end
		/// </summary>
		public ulong end;
	}

    public sealed class Range 
    {
		public ulong Start { get; set; } = 0;

		public ulong End { get; set; } = 0;
		
		public Range() 
		{
		    
		}

		internal static Range FromNative(BNRange raw)
		{
			return new Range()
			{
				Start = raw.start , 
				End = raw.end
			};
		}
    }
}