using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetUserFunctionReturnType(BNFunction* func, BNTypeWithConfidence* type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetUserFunctionReturnType"
        )]
		internal static extern void BNSetUserFunctionReturnType(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNTypeWithConfidence* type
		    in BNTypeWithConfidence type  
		);
	}
}