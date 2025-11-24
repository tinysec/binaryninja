using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNNamedTypeReference* BNGetTypeNamedTypeReference(BNType* type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetTypeNamedTypeReference"
        )]
		internal static extern IntPtr BNGetTypeNamedTypeReference(
			
			// BNType* type
		    IntPtr type  
		);
	}
}