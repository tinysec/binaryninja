using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNLineFormatterSettings* BNGetLanguageRepresentationLineFormatterSettings(BNDisassemblySettings* settings, BNLanguageRepresentationFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetLanguageRepresentationLineFormatterSettings"
        )]
		internal static extern IntPtr BNGetLanguageRepresentationLineFormatterSettings(
			
			// BNDisassemblySettings* settings
		    IntPtr settings  , 
			
			// BNLanguageRepresentationFunction* func
		    IntPtr func  
			
		);
	}
}