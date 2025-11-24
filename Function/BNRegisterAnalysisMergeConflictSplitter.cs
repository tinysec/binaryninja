using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNAnalysisMergeConflictSplitter* BNRegisterAnalysisMergeConflictSplitter(BNAnalysisMergeConflictSplitterCallbacks* callbacks)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRegisterAnalysisMergeConflictSplitter"
        )]
		internal static extern IntPtr BNRegisterAnalysisMergeConflictSplitter(
			
			// BNAnalysisMergeConflictSplitterCallbacks* callbacks
		    IntPtr callbacks  
			
		);
	}
}