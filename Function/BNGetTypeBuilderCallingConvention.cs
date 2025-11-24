using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNCallingConventionWithConfidence BNGetTypeBuilderCallingConvention(BNTypeBuilder* type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetTypeBuilderCallingConvention"
        )]
		internal static extern BNCallingConventionWithConfidence BNGetTypeBuilderCallingConvention(
			
			// BNTypeBuilder* type
		    IntPtr type  
		);
	}
}