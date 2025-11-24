using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNHighLevelILAddOperandList(BNHighLevelILFunction* func, uint64_t* operands, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNHighLevelILAddOperandList"
        )]
		internal static extern HighLevelILExpressionIndex BNHighLevelILAddOperandList(
			
			// BNHighLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t* operands
			ulong[] operands  , 
			
			// uint64_t count
		    ulong count  
		);
	}
}