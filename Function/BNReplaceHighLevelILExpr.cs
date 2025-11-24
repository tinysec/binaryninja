using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNReplaceHighLevelILExpr(BNHighLevelILFunction* func, uint64_t expr, uint64_t newExpr)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNReplaceHighLevelILExpr"
        )]
		internal static extern void BNReplaceHighLevelILExpr(
			
			// BNHighLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t expr
			HighLevelILExpressionIndex expr  , 
			
			// uint64_t newExpr
			HighLevelILExpressionIndex newExpr  
		);
	}
}