using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNVersionInfo BNPluginGetMaximumVersionInfo(BNRepoPlugin* p)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNPluginGetMaximumVersionInfo"
        )]
		internal static extern BNVersionInfo BNPluginGetMaximumVersionInfo(
			
			// BNRepoPlugin* p
		    IntPtr p  
			
		);
	}
}