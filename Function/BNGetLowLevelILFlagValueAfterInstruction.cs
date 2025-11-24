using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRegisterValue BNGetLowLevelILFlagValueAfterInstruction(BNLowLevelILFunction* func, uint32_t flag, uint64_t instr)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetLowLevelILFlagValueAfterInstruction"
        )]
		internal static extern BNRegisterValue BNGetLowLevelILFlagValueAfterInstruction(
			
			// BNLowLevelILFunction* func
		    IntPtr func  , 
			
			// uint32_t flag
			FlagIndex flag  , 
			
			// uint64_t instr
			LowLevelILInstructionIndex instr  
		);
	}
}