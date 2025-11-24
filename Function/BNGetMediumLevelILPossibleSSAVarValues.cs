using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNPossibleValueSet BNGetMediumLevelILPossibleSSAVarValues(BNMediumLevelILFunction* func, BNVariable* var, uint64_t version, uint64_t instr, BNDataFlowQueryOption* options, uint64_t optionCount)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetMediumLevelILPossibleSSAVarValues"
        )]
		internal static extern BNPossibleValueSet BNGetMediumLevelILPossibleSSAVarValues(
			
			// BNMediumLevelILFunction* func
		    IntPtr func  , 
			
			// BNVariable* _var
		    in BNVariable variable  , 
			
			// uint64_t version
		    ulong version  , 
			
			// uint64_t instr
			MediumLevelILInstructionIndex instr  , 
			
			// BNDataFlowQueryOption* options
		    DataFlowQueryOption[] options  , 
			
			// uint64_t optionCount
		    ulong optionCount  
		);
	}
}