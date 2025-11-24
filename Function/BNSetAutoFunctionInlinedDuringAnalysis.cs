using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetAutoFunctionInlinedDuringAnalysis(BNFunction* func, BNBoolWithConfidence inlined)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetAutoFunctionInlinedDuringAnalysis"
        )]
		internal static extern void BNSetAutoFunctionInlinedDuringAnalysis(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNBoolWithConfidence inlined
		    BoolWithConfidence inlined  
			
		);
	}
}