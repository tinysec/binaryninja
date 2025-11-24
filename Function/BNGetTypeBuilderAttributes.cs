using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNTypeAttribute* BNGetTypeBuilderAttributes(BNTypeBuilder* type, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetTypeBuilderAttributes"
        )]
		internal static extern IntPtr BNGetTypeBuilderAttributes(
			
			// BNTypeBuilder* type
		    IntPtr type  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}