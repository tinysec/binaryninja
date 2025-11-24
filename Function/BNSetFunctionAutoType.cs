using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetFunctionAutoType(BNFunction* func, BNType* type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetFunctionAutoType"
        )]
		internal static extern void BNSetFunctionAutoType(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNType* type
		    IntPtr type  
		);
	}
}