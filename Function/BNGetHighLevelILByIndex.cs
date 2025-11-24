using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNHighLevelILInstruction BNGetHighLevelILByIndex(BNHighLevelILFunction* func, uint64_t i, bool asFullAst)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetHighLevelILByIndex"
        )]
		internal static extern BNHighLevelILInstruction BNGetHighLevelILByIndex(
			
			// BNHighLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t i
			HighLevelILExpressionIndex i  , 
			
			// bool asFullAst
		    bool asFullAst 
		);
	}
}