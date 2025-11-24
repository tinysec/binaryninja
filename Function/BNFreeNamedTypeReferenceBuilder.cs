using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeNamedTypeReferenceBuilder(BNNamedTypeReferenceBuilder* s)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeNamedTypeReferenceBuilder"
        )]
		internal static extern void BNFreeNamedTypeReferenceBuilder(
			
			// BNNamedTypeReferenceBuilder* s
		    IntPtr s  
			
		);
	}
}