using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNEnumeration* BNGetTypeBuilderEnumeration(BNTypeBuilder* type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetTypeBuilderEnumeration"
        )]
		internal static extern IntPtr BNGetTypeBuilderEnumeration(
			
			// BNTypeBuilder* type
		    IntPtr type  
			
		);
	}
}