using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNTypeBuilderSetTypeName(BNTypeBuilder* type, BNQualifiedName* name)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNTypeBuilderSetTypeName"
        )]
		internal static extern void BNTypeBuilderSetTypeName(
			
			// BNTypeBuilder* type
		    IntPtr type  , 
			
			// BNQualifiedName* name
		    IntPtr name  
			
		);
	}
}