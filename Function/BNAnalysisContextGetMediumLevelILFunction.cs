using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNMediumLevelILFunction* BNAnalysisContextGetMediumLevelILFunction(BNAnalysisContext* analysisContext)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAnalysisContextGetMediumLevelILFunction"
        )]
		internal static extern IntPtr BNAnalysisContextGetMediumLevelILFunction(
			
			// BNAnalysisContext* analysisContext
		    IntPtr analysisContext  
		);
	}
}