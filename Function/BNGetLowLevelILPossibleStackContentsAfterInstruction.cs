using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNPossibleValueSet BNGetLowLevelILPossibleStackContentsAfterInstruction(BNLowLevelILFunction* func, int64_t offset, uint64_t len, uint64_t instr, BNDataFlowQueryOption* options, uint64_t optionCount)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetLowLevelILPossibleStackContentsAfterInstruction"
        )]
		internal static extern BNPossibleValueSet BNGetLowLevelILPossibleStackContentsAfterInstruction(
			
			// BNLowLevelILFunction* func
		    IntPtr func  , 
			
			// int64_t offset
		    long offset  , 
			
			// uint64_t len
		    ulong len  , 
			
			// uint64_t instr
			LowLevelILInstructionIndex instr  , 
			
			// BNDataFlowQueryOption* options
			DataFlowQueryOption[] options  , 
			
			// uint64_t optionCount
		    ulong optionCount  
		);
	}
}