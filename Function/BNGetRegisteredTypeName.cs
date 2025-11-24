using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNNamedTypeReference* BNGetRegisteredTypeName(BNType* type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetRegisteredTypeName"
        )]
		internal static extern IntPtr BNGetRegisteredTypeName(
			
			// BNType* type
		    IntPtr type  
			
		);
	}
}