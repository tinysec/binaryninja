using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNGetTypeReferenceBuilderId(BNNamedTypeReferenceBuilder* nt)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetTypeReferenceBuilderId"
        )]
		internal static extern IntPtr BNGetTypeReferenceBuilderId(
			
			// BNNamedTypeReferenceBuilder* nt
		    IntPtr nt  
			
		);
	}
}