using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNAnalyzeBasicBlocksContextSetDirectCodeReferences(BNBasicBlockAnalysisContext* abb, BNArchitectureAndAddress* sources, uint64_t* targets, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAnalyzeBasicBlocksContextSetDirectCodeReferences"
        )]
		internal static extern void BNAnalyzeBasicBlocksContextSetDirectCodeReferences(
			
			// BNBasicBlockAnalysisContext* abb
		    IntPtr abb  , 
			
			// BNArchitectureAndAddress* sources
		    IntPtr sources  , 
			
			// uint64_t* targets
		    IntPtr targets  , 
			
			// uint64_t count
		    ulong count  
		);
	}
}