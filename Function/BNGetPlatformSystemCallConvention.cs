using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNCallingConvention* BNGetPlatformSystemCallConvention(BNPlatform* platform)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetPlatformSystemCallConvention"
        )]
		internal static extern IntPtr BNGetPlatformSystemCallConvention(
			
			// BNPlatform* platform
		    IntPtr platform  
		);
	}
}