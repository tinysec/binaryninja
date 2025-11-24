using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNBasicBlock* BNGetHighLevelILBasicBlockForInstruction(BNHighLevelILFunction* func, uint64_t i)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetHighLevelILBasicBlockForInstruction"
        )]
		internal static extern IntPtr BNGetHighLevelILBasicBlockForInstruction(
			
			// BNHighLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t i
			HighLevelILInstructionIndex i  
		);
	}
}