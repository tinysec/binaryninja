using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNCallingConvention* BNGetPlatformCdeclCallingConvention(BNPlatform* platform)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetPlatformCdeclCallingConvention"
        )]
		internal static extern IntPtr BNGetPlatformCdeclCallingConvention(
			
			// BNPlatform* platform
		    IntPtr platform  
		);
	}
}