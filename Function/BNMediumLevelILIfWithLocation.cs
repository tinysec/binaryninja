using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNMediumLevelILIfWithLocation(BNMediumLevelILFunction* func, uint64_t op, BNMediumLevelILLabel* t, BNMediumLevelILLabel* f, uint64_t addr, uint32_t sourceOperand)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNMediumLevelILIfWithLocation"
        )]
		internal static extern MediumLevelILExpressionIndex BNMediumLevelILIfWithLocation(
			
			// BNMediumLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t op
			MediumLevelILExpressionIndex op  , 
			
			// BNMediumLevelILLabel* t
			in BNMediumLevelILLabel t  , 
			
			// BNMediumLevelILLabel* f
		    in BNMediumLevelILLabel f  , 
			
			// uint64_t addr
		    ulong address  , 
			
			// uint32_t sourceOperand
		    uint sourceOperand  
		);
	}
}