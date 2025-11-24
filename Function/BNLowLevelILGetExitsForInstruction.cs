using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t* BNLowLevelILGetExitsForInstruction(BNLowLevelILFunction* func, uint64_t instr, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNLowLevelILGetExitsForInstruction"
        )]
		internal static extern IntPtr BNLowLevelILGetExitsForInstruction(
			
			// BNLowLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t instr
			LowLevelILInstructionIndex instr  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}