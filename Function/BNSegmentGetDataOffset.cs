using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNSegmentGetDataOffset(BNSegment* segment)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSegmentGetDataOffset"
        )]
		internal static extern ulong BNSegmentGetDataOffset(
			
			// BNSegment* segment
		    IntPtr segment  
			
		);
	}
}