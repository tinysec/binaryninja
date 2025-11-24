using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNBoolWithConfidence BNIsFunctionPure(BNFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNIsFunctionPure"
        )]
		internal static extern BNBoolWithConfidence BNIsFunctionPure(
			
			// BNFunction* func
		    IntPtr func  
		);
	}
}