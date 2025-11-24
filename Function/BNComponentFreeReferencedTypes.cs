using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNComponentFreeReferencedTypes(BNType** types, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNComponentFreeReferencedTypes"
        )]
		internal static extern void BNComponentFreeReferencedTypes(
			
			// BNType** types
		    IntPtr types  , 
			
			// uint64_t count
		    ulong count  
		);
	}
}