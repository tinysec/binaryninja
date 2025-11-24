using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNLowLevelILFunction* BNAnalysisContextGetLowLevelILFunction(BNAnalysisContext* analysisContext)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAnalysisContextGetLowLevelILFunction"
        )]
		internal static extern IntPtr BNAnalysisContextGetLowLevelILFunction(
			
			// BNAnalysisContext* analysisContext
		    IntPtr analysisContext  
		);
	}
}