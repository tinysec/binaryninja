using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNAnalysisSkipReason BNGetAnalysisSkipReason(BNFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetAnalysisSkipReason"
        )]
		internal static extern AnalysisSkipReason BNGetAnalysisSkipReason(
			
			// BNFunction* func
		    IntPtr func  
			
		);
	}
}