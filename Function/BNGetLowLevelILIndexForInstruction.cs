using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNGetLowLevelILIndexForInstruction(BNLowLevelILFunction* func, uint64_t i)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetLowLevelILIndexForInstruction"
        )]
		internal static extern LowLevelILExpressionIndex BNGetLowLevelILIndexForInstruction(
			
			// BNLowLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t i
			LowLevelILInstructionIndex i  
		);
	}
}