using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNLowLevelILGotoWithLocation(BNLowLevelILFunction* func, BNLowLevelILLabel* label, uint64_t addr, uint32_t sourceOperand)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNLowLevelILGotoWithLocation"
        )]
		internal static extern LowLevelILExpressionIndex BNLowLevelILGotoWithLocation(
			
			// BNLowLevelILFunction* func
		    IntPtr func  , 
			
			// BNLowLevelILLabel* label
		    in BNLowLevelILLabel label  , 
			
			// uint64_t addr
		    ulong addr  , 
			
			// uint32_t sourceOperand
		    uint sourceOperand  
		);
	}
}