using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNGetHighLevelILIndexForInstruction(BNHighLevelILFunction* func, uint64_t i)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetHighLevelILIndexForInstruction"
        )]
		internal static extern HighLevelILExpressionIndex BNGetHighLevelILIndexForInstruction(
			
			// BNHighLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t i
			HighLevelILInstructionIndex i  
		);
	}
}