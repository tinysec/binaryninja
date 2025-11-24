using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNHighLevelILFunction* BNAnalysisContextGetHighLevelILFunction(BNAnalysisContext* analysisContext)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAnalysisContextGetHighLevelILFunction"
        )]
		internal static extern IntPtr BNAnalysisContextGetHighLevelILFunction(
			
			// BNAnalysisContext* analysisContext
		    IntPtr analysisContext  
		);
	}
}