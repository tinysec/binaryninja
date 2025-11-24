using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNVariable BNGetMediumLevelILVariableForFlagAfterInstruction(BNMediumLevelILFunction* func, uint32_t flag, uint64_t instr)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetMediumLevelILVariableForFlagAfterInstruction"
        )]
		internal static extern BNVariable BNGetMediumLevelILVariableForFlagAfterInstruction(
			
			// BNMediumLevelILFunction* func
		    IntPtr func  , 
			
			// uint32_t flag
			FlagIndex flag  , 
			
			// uint64_t instr
			MediumLevelILInstructionIndex instr  
		);
	}
}