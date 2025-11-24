using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNAnalysisMergeConflictSplitter** BNGetAnalysisMergeConflictSplitterList(uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetAnalysisMergeConflictSplitterList"
        )]
		internal static extern IntPtr BNGetAnalysisMergeConflictSplitterList(
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}