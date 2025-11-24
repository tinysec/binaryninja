using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNSegmentGetLength(BNSegment* segment)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSegmentGetLength"
        )]
		internal static extern ulong BNSegmentGetLength(
			
			// BNSegment* segment
		    IntPtr segment  
			
		);
	}
}