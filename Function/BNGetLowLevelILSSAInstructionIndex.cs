using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNGetLowLevelILSSAInstructionIndex(BNLowLevelILFunction* func, uint64_t instr)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetLowLevelILSSAInstructionIndex"
        )]
		internal static extern LowLevelILInstructionIndex BNGetLowLevelILSSAInstructionIndex(
			
			// BNLowLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t instr
			LowLevelILInstructionIndex instr  
		);
	}
}