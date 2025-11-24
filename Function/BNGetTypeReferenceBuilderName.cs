using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNQualifiedName BNGetTypeReferenceBuilderName(BNNamedTypeReferenceBuilder* nt)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetTypeReferenceBuilderName"
        )]
		internal static extern BNQualifiedName BNGetTypeReferenceBuilderName(
			
			// BNNamedTypeReferenceBuilder* nt
		    IntPtr nt  
		);
	}
}