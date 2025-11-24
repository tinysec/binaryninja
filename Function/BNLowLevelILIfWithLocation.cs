using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNLowLevelILIfWithLocation(BNLowLevelILFunction* func, uint64_t op, BNLowLevelILLabel* t, BNLowLevelILLabel* f, uint64_t addr, uint32_t sourceOperand)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNLowLevelILIfWithLocation"
        )]
		internal static extern LowLevelILExpressionIndex BNLowLevelILIfWithLocation(
			
			// BNLowLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t op
			LowLevelILExpressionIndex op  , 
			
			// BNLowLevelILLabel* t
		    in BNLowLevelILLabel t  , 
			
			// BNLowLevelILLabel* f
		    in BNLowLevelILLabel f  , 
			
			// uint64_t addr
		    ulong addr  , 
			
			// uint32_t sourceOperand
		    uint sourceOperand  
		);
	}
}