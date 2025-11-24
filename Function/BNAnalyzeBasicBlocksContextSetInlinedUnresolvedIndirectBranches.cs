using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNAnalyzeBasicBlocksContextSetInlinedUnresolvedIndirectBranches(BNBasicBlockAnalysisContext* abb, BNArchitectureAndAddress* locations, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAnalyzeBasicBlocksContextSetInlinedUnresolvedIndirectBranches"
        )]
		internal static extern void BNAnalyzeBasicBlocksContextSetInlinedUnresolvedIndirectBranches(
			
			// BNBasicBlockAnalysisContext* abb
		    IntPtr abb  , 
			
			// BNArchitectureAndAddress* locations
		    IntPtr locations  , 
			
			// uint64_t count
		    ulong count  
		);
	}
}