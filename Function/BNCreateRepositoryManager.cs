using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRepositoryManager* BNCreateRepositoryManager(const char* enabledPluginsPath)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNCreateRepositoryManager"
        )]
		internal static extern IntPtr BNCreateRepositoryManager(
			
			// const char* enabledPluginsPath
		    string enabledPluginsPath  
		);
	}
}