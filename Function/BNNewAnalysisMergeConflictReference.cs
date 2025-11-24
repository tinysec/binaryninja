using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNAnalysisMergeConflict* BNNewAnalysisMergeConflictReference(BNAnalysisMergeConflict* conflict)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNNewAnalysisMergeConflictReference"
        )]
		internal static extern IntPtr BNNewAnalysisMergeConflictReference(
			
			// BNAnalysisMergeConflict* conflict
		    IntPtr conflict  
			
		);
	}
}