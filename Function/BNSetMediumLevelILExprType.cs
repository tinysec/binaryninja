using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetMediumLevelILExprType(BNMediumLevelILFunction* func, uint64_t expr, BNTypeWithConfidence* type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetMediumLevelILExprType"
        )]
		internal static extern void BNSetMediumLevelILExprType(
			
			// BNMediumLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t expr
			MediumLevelILExpressionIndex expr  , 
			
			// BNTypeWithConfidence* type
		    in BNTypeWithConfidence type  
		);
	}
}