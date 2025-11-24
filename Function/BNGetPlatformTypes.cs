using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNQualifiedNameAndType* BNGetPlatformTypes(BNPlatform* platform, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetPlatformTypes"
        )]
		internal static extern IntPtr BNGetPlatformTypes(
			
			// BNPlatform* platform
		    IntPtr platform  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}