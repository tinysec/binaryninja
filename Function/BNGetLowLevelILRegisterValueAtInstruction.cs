using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRegisterValue BNGetLowLevelILRegisterValueAtInstruction(BNLowLevelILFunction* func, uint32_t reg, uint64_t instr)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetLowLevelILRegisterValueAtInstruction"
        )]
		internal static extern BNRegisterValue BNGetLowLevelILRegisterValueAtInstruction(
			
			// BNLowLevelILFunction* func
		    IntPtr func  , 
			
			// uint32_t reg
			RegisterIndex reg  , 
			
			// uint64_t instr
			LowLevelILInstructionIndex instr  
		);
	}
}