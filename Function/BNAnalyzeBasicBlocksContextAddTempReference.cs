using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNAnalyzeBasicBlocksContextAddTempReference(BNBasicBlockAnalysisContext* abb, BNFunction* target)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAnalyzeBasicBlocksContextAddTempReference"
        )]
		internal static extern void BNAnalyzeBasicBlocksContextAddTempReference(
			
			// BNBasicBlockAnalysisContext* abb
		    IntPtr abb  , 
			
			// BNFunction* target
		    IntPtr target  
		);
	}
}