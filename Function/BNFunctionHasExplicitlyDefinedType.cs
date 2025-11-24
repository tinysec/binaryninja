using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// bool BNFunctionHasExplicitlyDefinedType(BNFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFunctionHasExplicitlyDefinedType"
        )]
		internal static extern bool BNFunctionHasExplicitlyDefinedType(
			
			// BNFunction* func
		    IntPtr func  
		);
	}
}