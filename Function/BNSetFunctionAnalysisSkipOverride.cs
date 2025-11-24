using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetFunctionAnalysisSkipOverride(BNFunction* func, BNFunctionAnalysisSkipOverride skip)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetFunctionAnalysisSkipOverride"
        )]
		internal static extern void BNSetFunctionAnalysisSkipOverride(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNFunctionAnalysisSkipOverride skip
		    FunctionAnalysisSkipOverride skip  
			
		);
	}
}