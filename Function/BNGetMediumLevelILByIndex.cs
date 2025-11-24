using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNMediumLevelILInstruction BNGetMediumLevelILByIndex(BNMediumLevelILFunction* func, uint64_t i)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetMediumLevelILByIndex"
        )]
		internal static extern BNMediumLevelILInstruction BNGetMediumLevelILByIndex(
			
			// BNMediumLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t i
			MediumLevelILExpressionIndex i  
		);
	}
}