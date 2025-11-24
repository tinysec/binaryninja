using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNDatabase* BNAnalysisMergeConflictGetDatabase(BNAnalysisMergeConflict* conflict)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAnalysisMergeConflictGetDatabase"
        )]
		internal static extern IntPtr BNAnalysisMergeConflictGetDatabase(
			
			// BNAnalysisMergeConflict* conflict
		    IntPtr conflict  
		);
	}
}