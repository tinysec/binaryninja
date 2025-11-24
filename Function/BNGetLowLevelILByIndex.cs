using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNLowLevelILInstruction BNGetLowLevelILByIndex(BNLowLevelILFunction* func, uint64_t i)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetLowLevelILByIndex"
        )]
		internal static extern BNLowLevelILInstruction BNGetLowLevelILByIndex(
			
			// BNLowLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t i
			LowLevelILExpressionIndex i  
		);
	}
}