using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeSegmentList(BNSegment** segments, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeSegmentList"
        )]
		internal static extern void BNFreeSegmentList(
			
			// BNSegment** segments
		    IntPtr segments  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}