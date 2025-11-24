using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNAnalysisState BNGetAnalysisState(BNBinaryView* view)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetAnalysisState"
        )]
		internal static extern AnalysisState BNGetAnalysisState(
			
			// BNBinaryView* view
		    IntPtr view  
		);
	}
}