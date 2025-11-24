using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNPossibleValueSet BNGetLowLevelILPossibleRegisterValuesAtInstruction(BNLowLevelILFunction* func, uint32_t reg, uint64_t instr, BNDataFlowQueryOption* options, uint64_t optionCount)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetLowLevelILPossibleRegisterValuesAtInstruction"
        )]
		internal static extern BNPossibleValueSet BNGetLowLevelILPossibleRegisterValuesAtInstruction(
			
			// BNLowLevelILFunction* func
		    IntPtr func  , 
			
			// uint32_t reg
		    RegisterIndex reg  , 
			
			// uint64_t instr
			LowLevelILInstructionIndex instr  , 
			
			// BNDataFlowQueryOption* options
			DataFlowQueryOption[] options  , 
			
			// uint64_t optionCount
		    ulong optionCount  
		);
	}
}