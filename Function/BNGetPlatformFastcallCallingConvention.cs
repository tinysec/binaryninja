using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNCallingConvention* BNGetPlatformFastcallCallingConvention(BNPlatform* platform)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetPlatformFastcallCallingConvention"
        )]
		internal static extern IntPtr BNGetPlatformFastcallCallingConvention(
			
			// BNPlatform* platform
		    IntPtr platform  
		);
	}
}