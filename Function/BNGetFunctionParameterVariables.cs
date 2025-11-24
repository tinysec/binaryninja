using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNParameterVariablesWithConfidence BNGetFunctionParameterVariables(BNFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetFunctionParameterVariables"
        )]
		internal static extern BNParameterVariablesWithConfidence BNGetFunctionParameterVariables(
			
			// BNFunction* func
		    IntPtr func  
		);
	}
}