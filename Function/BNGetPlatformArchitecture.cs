using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNArchitecture* BNGetPlatformArchitecture(BNPlatform* platform)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetPlatformArchitecture"
        )]
		internal static extern IntPtr BNGetPlatformArchitecture(
			
			// BNPlatform* platform
		    IntPtr platform  
			
		);
	}
}