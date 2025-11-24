using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNLanguageRepresentationFunction* BNNewLanguageRepresentationFunctionReference(BNLanguageRepresentationFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNNewLanguageRepresentationFunctionReference"
        )]
		internal static extern IntPtr BNNewLanguageRepresentationFunctionReference(
			
			// BNLanguageRepresentationFunction* func
		    IntPtr func  
			
		);
	}
}