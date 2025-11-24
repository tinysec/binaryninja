using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNBasicBlock* BNGetLowLevelILBasicBlockForInstruction(BNLowLevelILFunction* func, uint64_t i)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetLowLevelILBasicBlockForInstruction"
        )]
		internal static extern IntPtr BNGetLowLevelILBasicBlockForInstruction(
			
			// BNLowLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t i
		    LowLevelILInstructionIndex i  
		);
	}
}