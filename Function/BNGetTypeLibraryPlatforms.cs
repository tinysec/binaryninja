using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// char** BNGetTypeLibraryPlatforms(BNTypeLibrary* lib, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetTypeLibraryPlatforms"
        )]
		internal static extern IntPtr BNGetTypeLibraryPlatforms(
			
			// BNTypeLibrary* lib
		    IntPtr lib  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}