using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNPointerBaseType BNTypeBuilderGetPointerBaseType(BNTypeBuilder* type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNTypeBuilderGetPointerBaseType"
        )]
		internal static extern PointerBaseType BNTypeBuilderGetPointerBaseType(
			
			// BNTypeBuilder* type
		    IntPtr type  
		);
	}
}