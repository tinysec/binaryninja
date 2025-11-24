using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNVariable BNGetMediumLevelILVariableForRegisterAtInstruction(BNMediumLevelILFunction* func, uint32_t reg, uint64_t instr)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetMediumLevelILVariableForRegisterAtInstruction"
        )]
		internal static extern BNVariable BNGetMediumLevelILVariableForRegisterAtInstruction(
			
			// BNMediumLevelILFunction* func
		    IntPtr func  , 
			
			// uint32_t reg
		    uint reg  , 
			
			// uint64_t instr
			MediumLevelILInstructionIndex instr  
		);
	}
}