using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNLowLevelILSetExprSourceOperand(BNLowLevelILFunction* func, uint64_t expr, uint32_t operand)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNLowLevelILSetExprSourceOperand"
        )]
		internal static extern void BNLowLevelILSetExprSourceOperand(
			
			// BNLowLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t expr
			LowLevelILExpressionIndex expr  , 
			
			// uint32_t operand
		    uint operand  
		);
	}
}