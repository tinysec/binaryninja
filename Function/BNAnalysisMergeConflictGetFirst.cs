using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNAnalysisMergeConflictGetFirst(BNAnalysisMergeConflict* conflict)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAnalysisMergeConflictGetFirst"
        )]
		internal static extern IntPtr BNAnalysisMergeConflictGetFirst(
			
			// BNAnalysisMergeConflict* conflict
		    IntPtr conflict  
		);
	}
}