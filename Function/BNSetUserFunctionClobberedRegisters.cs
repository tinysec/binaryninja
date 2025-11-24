using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetUserFunctionClobberedRegisters(BNFunction* func, BNRegisterSetWithConfidence* regs)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetUserFunctionClobberedRegisters"
        )]
		internal static extern void BNSetUserFunctionClobberedRegisters(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNRegisterSetWithConfidence* regs
		    IntPtr regs  
			
		);
	}
}