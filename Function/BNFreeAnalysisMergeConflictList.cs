using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeAnalysisMergeConflictList(BNAnalysisMergeConflict** conflicts, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeAnalysisMergeConflictList"
        )]
		internal static extern void BNFreeAnalysisMergeConflictList(
			
			// BNAnalysisMergeConflict** conflicts
		    IntPtr conflicts  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}