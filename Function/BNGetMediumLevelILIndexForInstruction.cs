using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNGetMediumLevelILIndexForInstruction(BNMediumLevelILFunction* func, uint64_t i)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetMediumLevelILIndexForInstruction"
        )]
		internal static extern MediumLevelILExpressionIndex BNGetMediumLevelILIndexForInstruction(
			
			// BNMediumLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t i
			MediumLevelILInstructionIndex i  
		);
	}
}