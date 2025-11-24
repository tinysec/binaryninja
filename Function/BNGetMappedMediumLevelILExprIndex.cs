using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNGetMappedMediumLevelILExprIndex(BNLowLevelILFunction* func, uint64_t expr)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetMappedMediumLevelILExprIndex"
        )]
		internal static extern MediumLevelILExpressionIndex BNGetMappedMediumLevelILExprIndex(
			
			// BNLowLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t expr
			LowLevelILExpressionIndex expr  
		);
	}
}