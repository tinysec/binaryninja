using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNAnalyzeBasicBlocksContextSetContextualFunctionReturns(BNBasicBlockAnalysisContext* abb, BNArchitectureAndAddress* sources, bool* values, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAnalyzeBasicBlocksContextSetContextualFunctionReturns"
        )]
		internal static extern void BNAnalyzeBasicBlocksContextSetContextualFunctionReturns(
			
			// BNBasicBlockAnalysisContext* abb
		    IntPtr abb  , 
			
			// BNArchitectureAndAddress* sources
		    IntPtr sources  , 
			
			// bool* values
		    IntPtr values  , 
			
			// uint64_t count
		    ulong count  
		);
	}
}