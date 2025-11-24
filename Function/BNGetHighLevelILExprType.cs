using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNTypeWithConfidence BNGetHighLevelILExprType(BNHighLevelILFunction* func, uint64_t expr)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetHighLevelILExprType"
        )]
		internal static extern BNTypeWithConfidence BNGetHighLevelILExprType(
			
			// BNHighLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t expr
			HighLevelILExpressionIndex expr  
		);
	}
}