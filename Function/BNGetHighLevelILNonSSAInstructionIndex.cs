using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNGetHighLevelILNonSSAInstructionIndex(BNHighLevelILFunction* func, uint64_t instr)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetHighLevelILNonSSAInstructionIndex"
        )]
		internal static extern HighLevelILInstructionIndex BNGetHighLevelILNonSSAInstructionIndex(
			
			// BNHighLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t instr
			HighLevelILInstructionIndex instr  
		);
	}
}