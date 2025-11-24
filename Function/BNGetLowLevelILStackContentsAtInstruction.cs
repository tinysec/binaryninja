using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRegisterValue BNGetLowLevelILStackContentsAtInstruction(BNLowLevelILFunction* func, int64_t offset, uint64_t len, uint64_t instr)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetLowLevelILStackContentsAtInstruction"
        )]
		internal static extern BNRegisterValue BNGetLowLevelILStackContentsAtInstruction(
			
			// BNLowLevelILFunction* func
		    IntPtr func  , 
			
			// int64_t offset
		    long offset  , 
			
			// uint64_t len
		    ulong len  , 
			
			// uint64_t instr
			LowLevelILInstructionIndex instr  
		);
	}
}