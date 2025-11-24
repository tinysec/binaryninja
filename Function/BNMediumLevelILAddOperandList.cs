using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNMediumLevelILAddOperandList(BNMediumLevelILFunction* func, uint64_t* operands, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNMediumLevelILAddOperandList"
        )]
		internal static extern MediumLevelILExpressionIndex BNMediumLevelILAddOperandList(
			
			// BNMediumLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t* operands
			ulong[] operands  , 
			
			// uint64_t count
		    ulong count  
		);
	}
}