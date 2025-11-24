using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNCallingConvention* BNGetPlatformDefaultCallingConvention(BNPlatform* platform)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetPlatformDefaultCallingConvention"
        )]
		internal static extern IntPtr BNGetPlatformDefaultCallingConvention(
			
			// BNPlatform* platform
		    IntPtr platform  
		);
	}
}