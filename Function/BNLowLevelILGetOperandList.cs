using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t* BNLowLevelILGetOperandList(BNLowLevelILFunction* func, uint64_t expr, uint64_t operand, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNLowLevelILGetOperandList"
        )]
		internal static extern IntPtr BNLowLevelILGetOperandList(
			
			// BNLowLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t expr
		    LowLevelILExpressionIndex expr  , 
			
			// uint64_t operand
			ulong operand  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}