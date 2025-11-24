using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetLowLevelILExprAttributes(BNLowLevelILFunction* func, uint64_t expr, uint32_t attributes)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetLowLevelILExprAttributes"
        )]
		internal static extern void BNSetLowLevelILExprAttributes(
			
			// BNLowLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t expr
			LowLevelILExpressionIndex expr  , 
			
			// uint32_t attributes
		    uint attributes  
		);
	}
}