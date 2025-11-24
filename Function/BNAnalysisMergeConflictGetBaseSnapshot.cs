using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNSnapshot* BNAnalysisMergeConflictGetBaseSnapshot(BNAnalysisMergeConflict* conflict)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAnalysisMergeConflictGetBaseSnapshot"
        )]
		internal static extern IntPtr BNAnalysisMergeConflictGetBaseSnapshot(
			
			// BNAnalysisMergeConflict* conflict
		    IntPtr conflict  
		);
	}
}