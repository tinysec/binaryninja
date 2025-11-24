using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNAnalysisMergeConflictGetSecond(BNAnalysisMergeConflict* conflict)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAnalysisMergeConflictGetSecond"
        )]
		internal static extern IntPtr BNAnalysisMergeConflictGetSecond(
			
			// BNAnalysisMergeConflict* conflict
		    IntPtr conflict  
		);
	}
}