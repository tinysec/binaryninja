using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNHighLevelILAddExprWithLocation(BNHighLevelILFunction* func, BNHighLevelILOperation operation, uint64_t addr, uint32_t sourceOperand, uint64_t size, uint64_t a, uint64_t b, uint64_t c, uint64_t d, uint64_t e)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNHighLevelILAddExprWithLocation"
        )]
		internal static extern HighLevelILExpressionIndex BNHighLevelILAddExprWithLocation(
			
			// BNHighLevelILFunction* func
		    IntPtr func  , 
			
			// BNHighLevelILOperation operation
		    HighLevelILOperation operation  , 
			
			// uint64_t addr
		    ulong addr  , 
			
			// uint32_t sourceOperand
		    uint sourceOperand  , 
			
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