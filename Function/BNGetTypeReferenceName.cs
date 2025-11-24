using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNQualifiedName BNGetTypeReferenceName(BNNamedTypeReference* nt)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetTypeReferenceName"
        )]
		internal static extern BNQualifiedName BNGetTypeReferenceName(
			
			// BNNamedTypeReference* nt
		    IntPtr nt  
		);
	}
}