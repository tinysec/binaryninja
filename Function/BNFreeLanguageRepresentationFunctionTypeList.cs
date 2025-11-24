using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeLanguageRepresentationFunctionTypeList(BNLanguageRepresentationFunctionType** types)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeLanguageRepresentationFunctionTypeList"
        )]
		internal static extern void BNFreeLanguageRepresentationFunctionTypeList(
			
			// BNLanguageRepresentationFunctionType** types
		    IntPtr types  
			
		);
	}
}