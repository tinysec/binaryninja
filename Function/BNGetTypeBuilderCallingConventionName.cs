using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNCallingConventionName BNGetTypeBuilderCallingConventionName(BNTypeBuilder* type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetTypeBuilderCallingConventionName"
        )]
		internal static extern CallingConventionName BNGetTypeBuilderCallingConventionName(
			
			// BNTypeBuilder* type
		    IntPtr type  
			
		);
	}
}