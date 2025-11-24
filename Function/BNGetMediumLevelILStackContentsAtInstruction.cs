using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRegisterValue BNGetMediumLevelILStackContentsAtInstruction(BNMediumLevelILFunction* func, int64_t offset, uint64_t len, uint64_t instr)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetMediumLevelILStackContentsAtInstruction"
        )]
		internal static extern BNRegisterValue BNGetMediumLevelILStackContentsAtInstruction(
			
			// BNMediumLevelILFunction* func
		    IntPtr func  , 
			
			// int64_t offset
		    long offset  , 
			
			// uint64_t len
		    ulong len  , 
			
			// uint64_t instr
			MediumLevelILInstructionIndex instr  
		);
	}
}