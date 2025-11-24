using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNFileMetadata* BNAnalysisMergeConflictGetSecondFile(BNAnalysisMergeConflict* conflict)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAnalysisMergeConflictGetSecondFile"
        )]
		internal static extern IntPtr BNAnalysisMergeConflictGetSecondFile(
			
			// BNAnalysisMergeConflict* conflict
		    IntPtr conflict  
		);
	}
}