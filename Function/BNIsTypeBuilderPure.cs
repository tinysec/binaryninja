using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNBoolWithConfidence BNIsTypeBuilderPure(BNTypeBuilder* type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNIsTypeBuilderPure"
        )]
		internal static extern BNBoolWithConfidence BNIsTypeBuilderPure(
			
			// BNTypeBuilder* type
		    IntPtr type  
		);
	}
}