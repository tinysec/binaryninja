using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRegisterSetWithConfidence BNGetFunctionClobberedRegisters(BNFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetFunctionClobberedRegisters"
        )]
		internal static extern BNRegisterSetWithConfidence BNGetFunctionClobberedRegisters(
			
			// BNFunction* func
		    IntPtr func  
			
		);
	}
}