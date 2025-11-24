using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNTypeBuilderSetCallingConvention(BNTypeBuilder* type, BNCallingConventionWithConfidence* cc)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNTypeBuilderSetCallingConvention"
        )]
		internal static extern void BNTypeBuilderSetCallingConvention(
			
			// BNTypeBuilder* type
		    IntPtr type  , 
			
			// BNCallingConventionWithConfidence* cc
		    in BNCallingConventionWithConfidence cc  
		);
	}
}