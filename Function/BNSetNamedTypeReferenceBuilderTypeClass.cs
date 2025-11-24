using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetNamedTypeReferenceBuilderTypeClass(BNNamedTypeReferenceBuilder* s, BNNamedTypeReferenceClass type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetNamedTypeReferenceBuilderTypeClass"
        )]
		internal static extern void BNSetNamedTypeReferenceBuilderTypeClass(
			
			// BNNamedTypeReferenceBuilder* s
		    IntPtr s  , 
			
			// BNNamedTypeReferenceClass type
		    NamedTypeReferenceClass type  
			
		);
	}
}