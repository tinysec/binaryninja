using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNPluginGetName(BNRepoPlugin* p)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNPluginGetName"
        )]
		internal static extern IntPtr BNPluginGetName(
			
			// BNRepoPlugin* p
		    IntPtr p  
			
		);
	}
}