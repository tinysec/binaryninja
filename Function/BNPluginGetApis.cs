using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char** BNPluginGetApis(BNRepoPlugin* p, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNPluginGetApis"
        )]
		internal static extern IntPtr BNPluginGetApis(
			
			// BNRepoPlugin* p
		    IntPtr p  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}