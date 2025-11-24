using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNAnalysisMergeConflictSplitterGetName(BNAnalysisMergeConflictSplitter* splitter)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAnalysisMergeConflictSplitterGetName"
        )]
		internal static extern IntPtr BNAnalysisMergeConflictSplitterGetName(
			
			// BNAnalysisMergeConflictSplitter* splitter
		    IntPtr splitter  
		);
	}
}