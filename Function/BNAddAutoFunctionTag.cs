using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNAddAutoFunctionTag(BNFunction* func, BNTag* tag)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAddAutoFunctionTag"
        )]
		internal static extern void BNAddAutoFunctionTag(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNTag* tag
		    IntPtr tag  
		);
	}
}