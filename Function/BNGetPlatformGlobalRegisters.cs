using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint32_t* BNGetPlatformGlobalRegisters(BNPlatform* platform, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetPlatformGlobalRegisters"
        )]
		internal static extern IntPtr BNGetPlatformGlobalRegisters(
			
			// BNPlatform* platform
		    IntPtr platform  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}