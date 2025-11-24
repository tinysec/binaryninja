using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetFunctionUserType(BNFunction* func, BNType* type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetFunctionUserType"
        )]
		internal static extern void BNSetFunctionUserType(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNType* type
		    IntPtr type  
			
		);
	}
}