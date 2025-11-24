using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNMediumLevelILGotoWithLocation(BNMediumLevelILFunction* func, BNMediumLevelILLabel* label, uint64_t addr, uint32_t sourceOperand)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNMediumLevelILGotoWithLocation"
        )]
		internal static extern MediumLevelILExpressionIndex BNMediumLevelILGotoWithLocation(
			
			// BNMediumLevelILFunction* func
		    IntPtr function  , 
			
			// BNMediumLevelILLabel* label
		    in BNMediumLevelILLabel label  , 
			
			// uint64_t addr
		    ulong address  , 
			
			// uint32_t sourceOperand
			OperandIndex sourceOperand  
		);
	}
}