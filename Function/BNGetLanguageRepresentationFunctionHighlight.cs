using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNHighlightColor BNGetLanguageRepresentationFunctionHighlight(BNLanguageRepresentationFunction* func, BNBasicBlock* block)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetLanguageRepresentationFunctionHighlight"
        )]
		internal static extern BNHighlightColor BNGetLanguageRepresentationFunctionHighlight(
			
			// BNLanguageRepresentationFunction* func
		    IntPtr func  , 
			
			// BNBasicBlock* block
		    IntPtr block  
		);
	}
}