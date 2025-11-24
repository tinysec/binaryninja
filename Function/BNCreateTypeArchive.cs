using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNTypeArchive* BNCreateTypeArchive(const char* path, BNPlatform* platform)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNCreateTypeArchive"
        )]
		internal static extern IntPtr BNCreateTypeArchive(
			
			// const char* path
		    string path  , 
			
			// BNPlatform* platform
		    IntPtr platform  
		);
	}
}