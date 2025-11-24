using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNILIndexRange 
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

    public sealed class ILIndexRange 
    {
		public ulong Start { get; set; } = 0;
		
		public ulong End { get; set; } = 0;
		
		public ILIndexRange() 
		{
		    
		}

		internal static ILIndexRange FromNative(BNILIndexRange raw)
		{
			return new ILIndexRange()
			{
				Start = raw.start , End = raw.end
			};
		}
    }
}