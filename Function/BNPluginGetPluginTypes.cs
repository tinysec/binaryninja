using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNPluginType* BNPluginGetPluginTypes(BNRepoPlugin* p, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNPluginGetPluginTypes"
        )]
		internal static extern IntPtr BNPluginGetPluginTypes(
			
			// BNRepoPlugin* p
		    IntPtr p  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}