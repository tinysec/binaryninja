using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetUserFunctionReturnRegisters(BNFunction* func, BNRegisterSetWithConfidence* regs)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetUserFunctionReturnRegisters"
        )]
		internal static extern void BNSetUserFunctionReturnRegisters(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNRegisterSetWithConfidence* regs
		    IntPtr regs  
			
		);
	}
}