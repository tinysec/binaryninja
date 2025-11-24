using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetUserFunctionParameterVariables(BNFunction* func, BNParameterVariablesWithConfidence* vars)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetUserFunctionParameterVariables"
        )]
		internal static extern void BNSetUserFunctionParameterVariables(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNParameterVariablesWithConfidence* vars
		    in BNParameterVariablesWithConfidence vars  
		);
	}
}