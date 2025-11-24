using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetAutoFunctionParameterVariables(BNFunction* func, BNParameterVariablesWithConfidence* vars)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetAutoFunctionParameterVariables"
        )]
		internal static extern void BNSetAutoFunctionParameterVariables(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNParameterVariablesWithConfidence* vars
		    IntPtr vars  
			
		);
	}
}