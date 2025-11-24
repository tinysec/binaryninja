using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRegisterValueWithConfidence BNGetFunctionRegisterValueAtExit(BNFunction* func, uint32_t reg)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetFunctionRegisterValueAtExit"
        )]
		internal static extern BNRegisterValueWithConfidence BNGetFunctionRegisterValueAtExit(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// uint32_t reg
		    uint reg  
			
		);
	}
}