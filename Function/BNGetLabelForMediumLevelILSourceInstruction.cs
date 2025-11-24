using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNMediumLevelILLabel* BNGetLabelForMediumLevelILSourceInstruction(BNMediumLevelILFunction* func, uint64_t instr)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetLabelForMediumLevelILSourceInstruction"
        )]
		internal static extern IntPtr BNGetLabelForMediumLevelILSourceInstruction(
			
			// BNMediumLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t instr
			MediumLevelILInstructionIndex instr  
		);
	}
}