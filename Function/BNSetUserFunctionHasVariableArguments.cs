using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetUserFunctionHasVariableArguments(BNFunction* func, BNBoolWithConfidence* varArgs)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetUserFunctionHasVariableArguments"
        )]
		internal static extern void BNSetUserFunctionHasVariableArguments(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNBoolWithConfidence* varArgs
		    in BNBoolWithConfidence varArgs  
		);
	}
}