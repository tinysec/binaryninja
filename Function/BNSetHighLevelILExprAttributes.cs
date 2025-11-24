using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetHighLevelILExprAttributes(BNHighLevelILFunction* func, uint64_t expr, uint32_t attributes)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetHighLevelILExprAttributes"
        )]
		internal static extern void BNSetHighLevelILExprAttributes(
			
			// BNHighLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t expr
			HighLevelILExpressionIndex expr  , 
			
			// uint32_t attributes
		    uint attributes  
		);
	}
}