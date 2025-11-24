using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNBoolWithConfidence BNTypeBuilderHasVariableArguments(BNTypeBuilder* type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNTypeBuilderHasVariableArguments"
        )]
		internal static extern BNBoolWithConfidence BNTypeBuilderHasVariableArguments(
			
			// BNTypeBuilder* type
		    IntPtr type  
		);
	}
}