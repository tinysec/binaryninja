using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNGetLanguageRepresentationFunctionAnnotationEndString(BNLanguageRepresentationFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetLanguageRepresentationFunctionAnnotationEndString"
        )]
		internal static extern IntPtr BNGetLanguageRepresentationFunctionAnnotationEndString(
			
			// BNLanguageRepresentationFunction* func
		    IntPtr func  
			
		);
	}
}