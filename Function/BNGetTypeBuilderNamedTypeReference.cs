using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNNamedTypeReference* BNGetTypeBuilderNamedTypeReference(BNTypeBuilder* type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetTypeBuilderNamedTypeReference"
        )]
		internal static extern IntPtr BNGetTypeBuilderNamedTypeReference(
			
			// BNTypeBuilder* type
		    IntPtr type  
			
		);
	}
}