using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetUserFunctionCallingConvention(BNFunction* func, BNCallingConventionWithConfidence* convention)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetUserFunctionCallingConvention"
        )]
		internal static extern void BNSetUserFunctionCallingConvention(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNCallingConventionWithConfidence* convention
		    in BNCallingConventionWithConfidence convention  
		);
	}
}