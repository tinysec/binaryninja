using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRegisterValue BNGetMediumLevelILRegisterValueAfterInstruction(BNMediumLevelILFunction* func, uint32_t reg, uint64_t instr)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetMediumLevelILRegisterValueAfterInstruction"
        )]
		internal static extern BNRegisterValue BNGetMediumLevelILRegisterValueAfterInstruction(
			
			// BNMediumLevelILFunction* func
		    IntPtr func  , 
			
			// uint32_t reg
			RegisterIndex reg  , 
			
			// uint64_t instr
			MediumLevelILInstructionIndex instr  
		);
	}
}