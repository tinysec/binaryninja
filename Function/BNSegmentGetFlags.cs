using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint32_t BNSegmentGetFlags(BNSegment* segment)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSegmentGetFlags"
        )]
		internal static extern uint BNSegmentGetFlags(
			
			// BNSegment* segment
		    IntPtr segment  
			
		);
	}
}