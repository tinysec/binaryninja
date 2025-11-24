using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNUpdateMediumLevelILOperand(BNMediumLevelILFunction* func, uint64_t instr, uint64_t operandIndex, uint64_t value)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNUpdateMediumLevelILOperand"
        )]
		internal static extern void BNUpdateMediumLevelILOperand(
			
			// BNMediumLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t instr
		    ulong instr  , 
			
			// uint64_t operandIndex
		    ulong operandIndex  , 
			
			// uint64_t _value
		    ulong _value  
			
		);
	}
}