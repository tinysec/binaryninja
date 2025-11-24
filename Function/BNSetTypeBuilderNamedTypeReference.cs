using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetTypeBuilderNamedTypeReference(BNTypeBuilder* type, BNNamedTypeReference* ntr)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetTypeBuilderNamedTypeReference"
        )]
		internal static extern void BNSetTypeBuilderNamedTypeReference(
			
			// BNTypeBuilder* type
		    IntPtr type  , 
			
			// BNNamedTypeReference* ntr
		    IntPtr ntr  
			
		);
	}
}