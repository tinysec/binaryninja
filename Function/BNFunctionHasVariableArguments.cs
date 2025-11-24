using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNBoolWithConfidence BNFunctionHasVariableArguments(BNFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFunctionHasVariableArguments"
        )]
		internal static extern BNBoolWithConfidence BNFunctionHasVariableArguments(
			
			// BNFunction* func
		    IntPtr func  
		);
	}
}