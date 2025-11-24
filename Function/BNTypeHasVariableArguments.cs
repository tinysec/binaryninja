using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNBoolWithConfidence BNTypeHasVariableArguments(BNType* type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNTypeHasVariableArguments"
        )]
		internal static extern BNBoolWithConfidence BNTypeHasVariableArguments(
			
			// BNType* type
		    IntPtr type  
		);
	}
}