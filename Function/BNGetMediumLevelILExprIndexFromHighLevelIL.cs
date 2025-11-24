using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNGetMediumLevelILExprIndexFromHighLevelIL(BNHighLevelILFunction* func, uint64_t expr)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetMediumLevelILExprIndexFromHighLevelIL"
        )]
		internal static extern MediumLevelILExpressionIndex BNGetMediumLevelILExprIndexFromHighLevelIL(
			
			// BNHighLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t expr
			HighLevelILExpressionIndex expr  
		);
	}
}