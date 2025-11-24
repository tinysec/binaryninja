using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNTypeBuilderSetSigned(BNTypeBuilder* type, BNBoolWithConfidence* sign)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNTypeBuilderSetSigned"
        )]
		internal static extern void BNTypeBuilderSetSigned(
			
			// BNTypeBuilder* type
		    IntPtr type  , 
			
			// BNBoolWithConfidence* sign
		    in BNBoolWithConfidence sign  
		);
	}
}