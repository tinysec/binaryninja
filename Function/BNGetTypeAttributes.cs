using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNTypeAttribute* BNGetTypeAttributes(BNType* type, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetTypeAttributes"
        )]
		internal static extern IntPtr BNGetTypeAttributes(
			
			// BNType* type
		    IntPtr type  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}