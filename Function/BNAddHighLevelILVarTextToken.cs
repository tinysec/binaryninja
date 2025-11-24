using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNAddHighLevelILVarTextToken(BNHighLevelILFunction* func, BNVariable* var, BNHighLevelILTokenEmitter* tokens, uint64_t exprIndex, uint64_t size)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAddHighLevelILVarTextToken"
        )]
		internal static extern void BNAddHighLevelILVarTextToken(
			
			// BNHighLevelILFunction* func
		    IntPtr func  , 
			
			// BNVariable* _var
		    IntPtr _var  , 
			
			// BNHighLevelILTokenEmitter* tokens
		    IntPtr tokens  , 
			
			// uint64_t exprIndex
		    ulong exprIndex  , 
			
			// uint64_t size
		    ulong size  
		);
	}
}