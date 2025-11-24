using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeNamedTypeReference(BNNamedTypeReference* nt)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeNamedTypeReference"
        )]
		internal static extern void BNFreeNamedTypeReference(
			
			// BNNamedTypeReference* nt
		    IntPtr nt  
			
		);
	}
}