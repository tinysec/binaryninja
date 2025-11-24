using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNNameType BNGetTypeBuilderNameType(BNTypeBuilder* type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetTypeBuilderNameType"
        )]
		internal static extern NameType BNGetTypeBuilderNameType(
			
			// BNTypeBuilder* type
		    IntPtr type  
			
		);
	}
}