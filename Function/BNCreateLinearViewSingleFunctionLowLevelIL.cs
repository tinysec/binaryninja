using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNLinearViewObject* BNCreateLinearViewSingleFunctionLowLevelIL(BNFunction* func, BNDisassemblySettings* settings)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreateLinearViewSingleFunctionLowLevelIL"
        )]
		internal static extern IntPtr BNCreateLinearViewSingleFunctionLowLevelIL(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNDisassemblySettings* settings
		    IntPtr settings  
		);
	}
}