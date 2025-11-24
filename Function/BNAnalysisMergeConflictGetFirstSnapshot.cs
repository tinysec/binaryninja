using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNSnapshot* BNAnalysisMergeConflictGetFirstSnapshot(BNAnalysisMergeConflict* conflict)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAnalysisMergeConflictGetFirstSnapshot"
        )]
		internal static extern IntPtr BNAnalysisMergeConflictGetFirstSnapshot(
			
			// BNAnalysisMergeConflict* conflict
		    IntPtr conflict  
		);
	}
}