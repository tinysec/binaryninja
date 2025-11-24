using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNPossibleValueSet BNGetMediumLevelILPossibleFlagValuesAfterInstruction(BNMediumLevelILFunction* func, uint32_t flag, uint64_t instr, BNDataFlowQueryOption* options, uint64_t optionCount)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetMediumLevelILPossibleFlagValuesAfterInstruction"
        )]
		internal static extern BNPossibleValueSet BNGetMediumLevelILPossibleFlagValuesAfterInstruction(
			
			// BNMediumLevelILFunction* func
		    IntPtr func  , 
			
			// uint32_t flag
			FlagIndex flag  , 
			
			// uint64_t instr
			MediumLevelILInstructionIndex instr  , 
			
			// BNDataFlowQueryOption* options
			DataFlowQueryOption[] options  , 
			
			// uint64_t optionCount
		    ulong optionCount  
		);
	}
}