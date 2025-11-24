using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNGetLanguageRepresentationFunctionTypeName(BNLanguageRepresentationFunctionType* type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetLanguageRepresentationFunctionTypeName"
        )]
		internal static extern IntPtr BNGetLanguageRepresentationFunctionTypeName(
			
			// BNLanguageRepresentationFunctionType* type
		    IntPtr type  
			
		);
	}
}