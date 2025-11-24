using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNMergeConflictDataType BNAnalysisMergeConflictGetDataType(BNAnalysisMergeConflict* conflict)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAnalysisMergeConflictGetDataType"
        )]
		internal static extern MergeConflictDataType BNAnalysisMergeConflictGetDataType(
			
			// BNAnalysisMergeConflict* conflict
		    IntPtr conflict  
		);
	}
}