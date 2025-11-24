using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNGetLowLevelILInstructionIndex(BNMediumLevelILFunction* func, uint64_t instr)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetLowLevelILInstructionIndex"
        )]
		internal static extern LowLevelILInstructionIndex BNGetLowLevelILInstructionIndex(
			
			// BNMediumLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t instr
			MediumLevelILInstructionIndex instr  
		);
	}
}