using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNReplaceMediumLevelILExpr(BNMediumLevelILFunction* func, uint64_t expr, uint64_t newExpr)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNReplaceMediumLevelILExpr"
        )]
		internal static extern void BNReplaceMediumLevelILExpr(
			
			// BNMediumLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t expr
			MediumLevelILExpressionIndex expr  , 
			
			// uint64_t newExpr
			MediumLevelILExpressionIndex newExpr  
		);
	}
}