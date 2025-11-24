using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNPointerSuffix* BNGetTypeBuilderPointerSuffix(BNTypeBuilder* type, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetTypeBuilderPointerSuffix"
        )]
		internal static extern IntPtr BNGetTypeBuilderPointerSuffix(
			
			// BNTypeBuilder* type
		    IntPtr type  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}