using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNLowLevelILGoto(BNLowLevelILFunction* func, BNLowLevelILLabel* label)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNLowLevelILGoto"
        )]
		internal static extern LowLevelILExpressionIndex BNLowLevelILGoto(
			
			// BNLowLevelILFunction* func
		    IntPtr func  , 
			
			// BNLowLevelILLabel* label
		    in BNLowLevelILLabel label  
		);
	}
}