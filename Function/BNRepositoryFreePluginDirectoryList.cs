using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNRepositoryFreePluginDirectoryList(const char** list, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRepositoryFreePluginDirectoryList"
        )]
		internal static extern void BNRepositoryFreePluginDirectoryList(
			
			// const char** list
		    string[] list  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}