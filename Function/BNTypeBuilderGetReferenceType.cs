using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNReferenceType BNTypeBuilderGetReferenceType(BNTypeBuilder* type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNTypeBuilderGetReferenceType"
        )]
		internal static extern ReferenceType BNTypeBuilderGetReferenceType(
			
			// BNTypeBuilder* type
		    IntPtr type  
			
		);
	}
}