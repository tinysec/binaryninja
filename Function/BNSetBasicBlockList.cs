using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetBasicBlockList(BNAnalysisContext* analysisContext, BNBasicBlock** basicBlocks, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetBasicBlockList"
        )]
		internal static extern void BNSetBasicBlockList(
			
			// BNAnalysisContext* analysisContext
		    IntPtr analysisContext  , 
			
			// BNBasicBlock** basicBlocks
		    IntPtr basicBlocks  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}