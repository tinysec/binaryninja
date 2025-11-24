using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNReplaceLowLevelILExpr(BNLowLevelILFunction* func, uint64_t expr, uint64_t newExpr)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNReplaceLowLevelILExpr"
        )]
		internal static extern void BNReplaceLowLevelILExpr(
			
			// BNLowLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t expr
			LowLevelILExpressionIndex expr  , 
			
			// uint64_t newExpr
			LowLevelILExpressionIndex newExpr  
		);
	}
}