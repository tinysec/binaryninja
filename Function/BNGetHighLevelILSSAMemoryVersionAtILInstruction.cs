using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNGetHighLevelILSSAMemoryVersionAtILInstruction(BNHighLevelILFunction* func, uint64_t instr)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetHighLevelILSSAMemoryVersionAtILInstruction"
        )]
		internal static extern ulong BNGetHighLevelILSSAMemoryVersionAtILInstruction(
			
			// BNHighLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t instr
			HighLevelILInstructionIndex instr  
		);
	}
}