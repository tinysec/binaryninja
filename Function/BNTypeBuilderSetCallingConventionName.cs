using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNTypeBuilderSetCallingConventionName(BNTypeBuilder* type, BNCallingConventionName cc)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNTypeBuilderSetCallingConventionName"
        )]
		internal static extern void BNTypeBuilderSetCallingConventionName(
			
			// BNTypeBuilder* type
		    IntPtr type  , 
			
			// BNCallingConventionName cc
		    CallingConventionName cc  
			
		);
	}
}