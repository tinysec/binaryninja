using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNType* BNGetPlatformGlobalRegisterType(BNPlatform* platform, uint32_t reg)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetPlatformGlobalRegisterType"
        )]
		internal static extern IntPtr BNGetPlatformGlobalRegisterType(
			
			// BNPlatform* platform
		    IntPtr platform  , 
			
			// uint32_t reg
		    uint reg  
			
		);
	}
}