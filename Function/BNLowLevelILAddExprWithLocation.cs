using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNLowLevelILAddExprWithLocation(BNLowLevelILFunction* func, uint64_t addr, uint32_t sourceOperand, BNLowLevelILOperation operation, uint64_t size, uint32_t flags, uint64_t a, uint64_t b, uint64_t c, uint64_t d)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNLowLevelILAddExprWithLocation"
        )]
		internal static extern LowLevelILExpressionIndex BNLowLevelILAddExprWithLocation(
			
			// BNLowLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t addr
		    ulong addr  , 
			
			// uint32_t sourceOperand
			OperandIndex sourceOperand  , 
			
			// BNLowLevelILOperation operation
		    LowLevelILOperation operation  , 
			
			// uint64_t size
		    ulong size  , 
			
			// uint32_t flags
		    uint flags  , 
			
			// uint64_t a
		    ulong a  , 
			
			// uint64_t b
		    ulong b  , 
			
			// uint64_t c
		    ulong c  , 
			
			// uint64_t d
		    ulong d  
		);
	}
}