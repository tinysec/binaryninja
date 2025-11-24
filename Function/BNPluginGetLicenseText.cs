using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNPluginGetLicenseText(BNRepoPlugin* p)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNPluginGetLicenseText"
        )]
		internal static extern IntPtr BNPluginGetLicenseText(
			
			// BNRepoPlugin* p
		    IntPtr p  
			
		);
	}
}