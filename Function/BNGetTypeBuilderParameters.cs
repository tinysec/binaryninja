using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNFunctionParameter* BNGetTypeBuilderParameters(BNTypeBuilder* type, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetTypeBuilderParameters"
        )]
		internal static extern IntPtr BNGetTypeBuilderParameters(
			
			// BNTypeBuilder* type
		    IntPtr type  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}