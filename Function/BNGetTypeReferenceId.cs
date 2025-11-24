using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNGetTypeReferenceId(BNNamedTypeReference* nt)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetTypeReferenceId"
        )]
		internal static extern IntPtr BNGetTypeReferenceId(
			
			// BNNamedTypeReference* nt
		    IntPtr nt  
		);
	}
}