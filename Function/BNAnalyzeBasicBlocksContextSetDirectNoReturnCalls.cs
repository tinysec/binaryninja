using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNAnalyzeBasicBlocksContextSetDirectNoReturnCalls(BNBasicBlockAnalysisContext* abb, BNArchitectureAndAddress* sources, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAnalyzeBasicBlocksContextSetDirectNoReturnCalls"
        )]
		internal static extern void BNAnalyzeBasicBlocksContextSetDirectNoReturnCalls(
			
			// BNBasicBlockAnalysisContext* abb
		    IntPtr abb  , 
			
			// BNArchitectureAndAddress* sources
		    IntPtr sources  , 
			
			// uint64_t count
		    ulong count  
		);
	}
}