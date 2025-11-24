using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNLowLevelILIf(BNLowLevelILFunction* func, uint64_t op, BNLowLevelILLabel* t, BNLowLevelILLabel* f)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNLowLevelILIf"
        )]
		internal static extern LowLevelILExpressionIndex BNLowLevelILIf(
			
			// BNLowLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t op
			LowLevelILExpressionIndex op  , 
			
			// BNLowLevelILLabel* t
		    in BNLowLevelILLabel t  , 
			
			// BNLowLevelILLabel* f
		    in BNLowLevelILLabel f  
		);
	}
}