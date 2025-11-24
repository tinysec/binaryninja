using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNAnalysisParameters BNGetParametersForAnalysis(BNBinaryView* view)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetParametersForAnalysis"
        )]
		internal static extern BNAnalysisParameters BNGetParametersForAnalysis(
			
			// BNBinaryView* view
		    IntPtr view  
		);
	}
}