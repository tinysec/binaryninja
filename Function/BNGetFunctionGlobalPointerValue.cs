using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRegisterValueWithConfidence BNGetFunctionGlobalPointerValue(BNFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetFunctionGlobalPointerValue"
        )]
		internal static extern BNRegisterValueWithConfidence BNGetFunctionGlobalPointerValue(
			
			// BNFunction* func
		    IntPtr func  
			
		);
	}
}