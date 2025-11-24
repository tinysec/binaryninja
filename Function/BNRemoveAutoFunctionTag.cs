using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNRemoveAutoFunctionTag(BNFunction* func, BNTag* tag)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRemoveAutoFunctionTag"
        )]
		internal static extern void BNRemoveAutoFunctionTag(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNTag* tag
		    IntPtr tag  
			
		);
	}
}