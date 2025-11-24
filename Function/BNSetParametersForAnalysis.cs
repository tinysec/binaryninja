using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetParametersForAnalysis(BNBinaryView* view, BNAnalysisParameters @params)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetParametersForAnalysis"
        )]
		internal static extern void BNSetParametersForAnalysis(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNAnalysisParameters parameters
		    in BNAnalysisParameters parameters  
		);
	}
}