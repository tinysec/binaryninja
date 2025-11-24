using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetMediumLevelILExprAttributes(BNMediumLevelILFunction* func, uint64_t expr, uint32_t attributes)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetMediumLevelILExprAttributes"
        )]
		internal static extern void BNSetMediumLevelILExprAttributes(
			
			// BNMediumLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t expr
			MediumLevelILExpressionIndex expr  , 
			
			// uint32_t attributes
		    uint attributes  
		);
	}
}