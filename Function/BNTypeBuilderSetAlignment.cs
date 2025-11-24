using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNTypeBuilderSetAlignment(BNTypeBuilder* type, uint64_t alignment)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNTypeBuilderSetAlignment"
        )]
		internal static extern void BNTypeBuilderSetAlignment(
			
			// BNTypeBuilder* type
		    IntPtr type  , 
			
			// uint64_t alignment
		    ulong alignment  
		);
	}
}