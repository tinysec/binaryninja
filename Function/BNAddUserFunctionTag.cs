using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNAddUserFunctionTag(BNFunction* func, BNTag* tag)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAddUserFunctionTag"
        )]
		internal static extern void BNAddUserFunctionTag(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNTag* tag
		    IntPtr tag  
		);
	}
}