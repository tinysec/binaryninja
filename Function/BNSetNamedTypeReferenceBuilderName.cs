using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetNamedTypeReferenceBuilderName(BNNamedTypeReferenceBuilder* s, BNQualifiedName* name)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetNamedTypeReferenceBuilderName"
        )]
		internal static extern void BNSetNamedTypeReferenceBuilderName(
			
			// BNNamedTypeReferenceBuilder* s
		    IntPtr s  , 
			
			// BNQualifiedName* name
		    IntPtr name  
			
		);
	}
}