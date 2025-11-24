using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNAnalyzeBasicBlocksContextAddBasicBlockToFunction(BNBasicBlockAnalysisContext* abb, BNBasicBlock* block)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAnalyzeBasicBlocksContextAddBasicBlockToFunction"
        )]
		internal static extern void BNAnalyzeBasicBlocksContextAddBasicBlockToFunction(
			
			// BNBasicBlockAnalysisContext* abb
		    IntPtr abb  , 
			
			// BNBasicBlock* block
		    IntPtr block  
		);
	}
}