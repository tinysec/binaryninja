using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNTypePrinter* BNGetLanguageRepresentationFunctionTypePrinter(BNLanguageRepresentationFunctionType* type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetLanguageRepresentationFunctionTypePrinter"
        )]
		internal static extern IntPtr BNGetLanguageRepresentationFunctionTypePrinter(
			
			// BNLanguageRepresentationFunctionType* type
		    IntPtr type  
			
		);
	}
}