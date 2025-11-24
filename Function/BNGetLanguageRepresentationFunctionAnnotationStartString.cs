using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNGetLanguageRepresentationFunctionAnnotationStartString(BNLanguageRepresentationFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetLanguageRepresentationFunctionAnnotationStartString"
        )]
		internal static extern IntPtr BNGetLanguageRepresentationFunctionAnnotationStartString(
			
			// BNLanguageRepresentationFunction* func
		    IntPtr func  
			
		);
	}
}