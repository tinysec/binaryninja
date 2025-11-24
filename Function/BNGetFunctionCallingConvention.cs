using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNCallingConventionWithConfidence BNGetFunctionCallingConvention(BNFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetFunctionCallingConvention"
        )]
		internal static extern BNCallingConventionWithConfidence BNGetFunctionCallingConvention(
			
			// BNFunction* func
		    IntPtr func  
		);
	}
}