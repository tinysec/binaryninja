using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRegisterValue BNGetLowLevelILRegisterValueAfterInstruction(BNLowLevelILFunction* func, uint32_t reg, uint64_t instr)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetLowLevelILRegisterValueAfterInstruction"
        )]
		internal static extern BNRegisterValue BNGetLowLevelILRegisterValueAfterInstruction(
			
			// BNLowLevelILFunction* func
		    IntPtr func  , 
			
			// uint32_t reg
		    uint reg  , 
			
			// uint64_t instr
			LowLevelILInstructionIndex instr  
		);
	}
}