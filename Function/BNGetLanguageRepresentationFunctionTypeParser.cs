using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNTypeParser* BNGetLanguageRepresentationFunctionTypeParser(BNLanguageRepresentationFunctionType* type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetLanguageRepresentationFunctionTypeParser"
        )]
		internal static extern IntPtr BNGetLanguageRepresentationFunctionTypeParser(
			
			// BNLanguageRepresentationFunctionType* type
		    IntPtr type  
			
		);
	}
}