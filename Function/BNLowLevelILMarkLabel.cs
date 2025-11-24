using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNLowLevelILMarkLabel(BNLowLevelILFunction* func, BNLowLevelILLabel* label)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNLowLevelILMarkLabel"
        )]
		internal static extern void BNLowLevelILMarkLabel(
			
			// BNLowLevelILFunction* func
		    IntPtr func  , 
			
			// BNLowLevelILLabel* label
		    in BNLowLevelILLabel label  
		);
	}
}