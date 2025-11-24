using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNMediumLevelILAddExprWithLocation(BNMediumLevelILFunction* func, BNMediumLevelILOperation operation, uint64_t addr, uint32_t sourceOperand, uint64_t size, uint64_t a, uint64_t b, uint64_t c, uint64_t d, uint64_t e)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNMediumLevelILAddExprWithLocation"
        )]
		internal static extern MediumLevelILExpressionIndex BNMediumLevelILAddExprWithLocation(
			
			// BNMediumLevelILFunction* func
		    IntPtr func  , 
			
			// BNMediumLevelILOperation operation
		    MediumLevelILOperation operation  , 
			
			// uint64_t addr
		    ulong address  , 
			
			// uint32_t sourceOperand
		    OperandIndex sourceOperand  , 
			
			// uint64_t size
		    ulong size  , 
			
			// uint64_t a
		    ulong a  , 
			
			// uint64_t b
		    ulong b  , 
			
			// uint64_t c
		    ulong c  , 
			
			// uint64_t d
		    ulong d  , 
			
			// uint64_t e
		    ulong e  
		);
	}
}