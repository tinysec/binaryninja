using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNGetHighLevelILNonSSAExprIndex(BNHighLevelILFunction* func, uint64_t expr)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetHighLevelILNonSSAExprIndex"
        )]
		internal static extern HighLevelILExpressionIndex BNGetHighLevelILNonSSAExprIndex(
			
			// BNHighLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t expr
			HighLevelILExpressionIndex expr  
		);
	}
}