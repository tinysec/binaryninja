using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNUpdateLowLevelILOperand(BNLowLevelILFunction* func, uint64_t instr, uint64_t operandIndex, uint64_t value)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNUpdateLowLevelILOperand"
        )]
		internal static extern void BNUpdateLowLevelILOperand(
			
			// BNLowLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t instr
		    LowLevelILInstructionIndex instr  , 
			
			// uint64_t operandIndex
		    OperandIndex operandIndex  , 
			
			// uint64_t _value
		    ulong _value  
		);
	}
}