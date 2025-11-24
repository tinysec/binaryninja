using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreePluginPlatforms(const char** platforms, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreePluginPlatforms"
        )]
		internal static extern void BNFreePluginPlatforms(
			
			// const char** platforms
		    string[] platforms  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}