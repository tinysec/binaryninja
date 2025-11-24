using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNNamedTypeReferenceClass BNGetTypeReferenceBuilderClass(BNNamedTypeReferenceBuilder* nt)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetTypeReferenceBuilderClass"
        )]
		internal static extern NamedTypeReferenceClass BNGetTypeReferenceBuilderClass(
			
			// BNNamedTypeReferenceBuilder* nt
		    IntPtr nt  
		);
	}
}