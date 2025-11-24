using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNAnalysisMergeConflictGetBase(BNAnalysisMergeConflict* conflict)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAnalysisMergeConflictGetBase"
        )]
		internal static extern IntPtr BNAnalysisMergeConflictGetBase(
			
			// BNAnalysisMergeConflict* conflict
		    IntPtr conflict  
		);
	}
}