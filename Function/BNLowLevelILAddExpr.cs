using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNLowLevelILAddExpr(BNLowLevelILFunction* func, BNLowLevelILOperation operation, uint64_t size, uint32_t flags, uint64_t a, uint64_t b, uint64_t c, uint64_t d)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNLowLevelILAddExpr"
        )]
		internal static extern LowLevelILExpressionIndex BNLowLevelILAddExpr(
			
			// BNLowLevelILFunction* func
		    IntPtr func  , 
			
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