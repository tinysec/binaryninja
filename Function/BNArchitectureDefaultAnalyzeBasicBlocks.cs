using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNArchitectureDefaultAnalyzeBasicBlocks(BNFunction* function, BNBasicBlockAnalysisContext* context)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNArchitectureDefaultAnalyzeBasicBlocks"
        )]
		internal static extern void BNArchitectureDefaultAnalyzeBasicBlocks(
			
			// BNFunction* function
		    IntPtr function  , 
			
			// BNBasicBlockAnalysisContext* context
		    IntPtr context  
		);
	}
}