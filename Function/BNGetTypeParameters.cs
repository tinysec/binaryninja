using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNFunctionParameter* BNGetTypeParameters(BNType* type, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetTypeParameters"
        )]
		internal static extern IntPtr BNGetTypeParameters(
			
			// BNType* type
		    IntPtr type  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}