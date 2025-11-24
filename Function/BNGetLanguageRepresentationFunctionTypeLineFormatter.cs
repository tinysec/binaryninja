using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNLineFormatter* BNGetLanguageRepresentationFunctionTypeLineFormatter(BNLanguageRepresentationFunctionType* type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetLanguageRepresentationFunctionTypeLineFormatter"
        )]
		internal static extern IntPtr BNGetLanguageRepresentationFunctionTypeLineFormatter(
			
			// BNLanguageRepresentationFunctionType* type
		    IntPtr type  
			
		);
	}
}