using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNPointerSuffix* BNGetTypePointerSuffix(BNType* type, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetTypePointerSuffix"
        )]
		internal static extern IntPtr BNGetTypePointerSuffix(
			
			// BNType* type
		    IntPtr type  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}