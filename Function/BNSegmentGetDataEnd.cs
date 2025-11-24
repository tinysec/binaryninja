using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNSegmentGetDataEnd(BNSegment* segment)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSegmentGetDataEnd"
        )]
		internal static extern ulong BNSegmentGetDataEnd(
			
			// BNSegment* segment
		    IntPtr segment  
			
		);
	}
}