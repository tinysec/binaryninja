using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNCallingConvention* BNGetPlatformStdcallCallingConvention(BNPlatform* platform)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetPlatformStdcallCallingConvention"
        )]
		internal static extern IntPtr BNGetPlatformStdcallCallingConvention(
			
			// BNPlatform* platform
		    IntPtr platform  
		);
	}
}