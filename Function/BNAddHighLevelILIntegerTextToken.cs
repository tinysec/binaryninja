using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNAddHighLevelILIntegerTextToken(BNHighLevelILFunction* func, uint64_t exprIndex, int64_t val, uint64_t size, BNHighLevelILTokenEmitter* tokens)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAddHighLevelILIntegerTextToken"
        )]
		internal static extern void BNAddHighLevelILIntegerTextToken(
			
			// BNHighLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t exprIndex
		    ulong exprIndex  , 
			
			// int64_t val
		    long val  , 
			
			// uint64_t size
		    ulong size  , 
			
			// BNHighLevelILTokenEmitter* tokens
		    IntPtr tokens  
		);
	}
}