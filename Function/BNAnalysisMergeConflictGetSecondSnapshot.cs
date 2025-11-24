using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNSnapshot* BNAnalysisMergeConflictGetSecondSnapshot(BNAnalysisMergeConflict* conflict)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAnalysisMergeConflictGetSecondSnapshot"
        )]
		internal static extern IntPtr BNAnalysisMergeConflictGetSecondSnapshot(
			
			// BNAnalysisMergeConflict* conflict
		    IntPtr conflict  
		);
	}
}