using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNBoolWithConfidence BNFunctionTypeBuilderCanReturn(BNTypeBuilder* type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFunctionTypeBuilderCanReturn"
        )]
		internal static extern BNBoolWithConfidence BNFunctionTypeBuilderCanReturn(
			
			// BNTypeBuilder* type
		    IntPtr type  
		);
	}
}