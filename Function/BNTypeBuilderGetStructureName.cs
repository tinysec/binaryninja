using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNQualifiedName BNTypeBuilderGetStructureName(BNTypeBuilder* type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNTypeBuilderGetStructureName"
        )]
		internal static extern BNQualifiedName BNTypeBuilderGetStructureName(
			
			// BNTypeBuilder* type
		    IntPtr type  
			
		);
	}
}