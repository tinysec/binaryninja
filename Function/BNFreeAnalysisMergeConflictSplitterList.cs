using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeAnalysisMergeConflictSplitterList(BNAnalysisMergeConflictSplitter** splitters, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeAnalysisMergeConflictSplitterList"
        )]
		internal static extern void BNFreeAnalysisMergeConflictSplitterList(
			
			// BNAnalysisMergeConflictSplitter** splitters
		    IntPtr splitters  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}