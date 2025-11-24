using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNGetPlatformSystemCallName(BNPlatform* platform, uint32_t number)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetPlatformSystemCallName"
        )]
		internal static extern IntPtr BNGetPlatformSystemCallName(
			
			// BNPlatform* platform
		    IntPtr platform  , 
			
			// uint32_t number
		    uint number  
		);
	}
}