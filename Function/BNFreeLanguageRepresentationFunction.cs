using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeLanguageRepresentationFunction(BNLanguageRepresentationFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeLanguageRepresentationFunction"
        )]
		internal static extern void BNFreeLanguageRepresentationFunction(
			
			// BNLanguageRepresentationFunction* func
		    IntPtr func  
			
		);
	}
}