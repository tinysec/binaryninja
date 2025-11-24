using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// char* BNGetLanguageRepresentationFunctionCommentStartString(BNLanguageRepresentationFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetLanguageRepresentationFunctionCommentStartString"
        )]
		internal static extern IntPtr BNGetLanguageRepresentationFunctionCommentStartString(
			
			// BNLanguageRepresentationFunction* func
		    IntPtr func  
		);
	}
}