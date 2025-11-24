using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNAddUserSegments(BNBinaryView* view, BNSegmentInfo* segmentInfo, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAddUserSegments"
        )]
		internal static extern void BNAddUserSegments(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNSegmentInfo* segmentInfo
			BNSegmentInfo[] segmentInfo  , 
			
			// uint64_t count
		    ulong count  
		);
	}
}