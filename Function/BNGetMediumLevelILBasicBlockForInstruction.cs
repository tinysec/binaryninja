using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNBasicBlock* BNGetMediumLevelILBasicBlockForInstruction(BNMediumLevelILFunction* func, uint64_t i)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetMediumLevelILBasicBlockForInstruction"
        )]
		internal static extern IntPtr BNGetMediumLevelILBasicBlockForInstruction(
			
			// BNMediumLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t i
			MediumLevelILInstructionIndex i  
		);
	}
}