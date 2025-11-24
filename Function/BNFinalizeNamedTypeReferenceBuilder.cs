using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNNamedTypeReference* BNFinalizeNamedTypeReferenceBuilder(BNNamedTypeReferenceBuilder* s)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFinalizeNamedTypeReferenceBuilder"
        )]
		internal static extern IntPtr BNFinalizeNamedTypeReferenceBuilder(
			
			// BNNamedTypeReferenceBuilder* s
		    IntPtr s  
			
		);
	}
}