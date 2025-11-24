using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNFileMetadata* BNAnalysisMergeConflictGetBaseFile(BNAnalysisMergeConflict* conflict)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAnalysisMergeConflictGetBaseFile"
        )]
		internal static extern IntPtr BNAnalysisMergeConflictGetBaseFile(
			
			// BNAnalysisMergeConflict* conflict
		    IntPtr conflict  
		);
	}
}