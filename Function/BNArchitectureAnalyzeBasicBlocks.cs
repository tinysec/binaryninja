using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNArchitectureAnalyzeBasicBlocks(BNArchitecture* arch, BNFunction* function, BNBasicBlockAnalysisContext* context)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNArchitectureAnalyzeBasicBlocks"
        )]
		internal static extern void BNArchitectureAnalyzeBasicBlocks(
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// BNFunction* function
		    IntPtr function  , 
			
			// BNBasicBlockAnalysisContext* context
		    IntPtr context  
		);
	}
}