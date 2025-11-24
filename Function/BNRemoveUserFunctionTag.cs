using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNRemoveUserFunctionTag(BNFunction* func, BNTag* tag)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNRemoveUserFunctionTag"
        )]
		internal static extern void BNRemoveUserFunctionTag(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNTag* tag
		    IntPtr tag  
		);
	}
}