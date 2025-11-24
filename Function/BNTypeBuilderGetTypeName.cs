using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNQualifiedName BNTypeBuilderGetTypeName(BNTypeBuilder* nt)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNTypeBuilderGetTypeName"
        )]
		internal static extern BNQualifiedName BNTypeBuilderGetTypeName(
			
			// BNTypeBuilder* nt
		    IntPtr nt  
			
		);
	}
}