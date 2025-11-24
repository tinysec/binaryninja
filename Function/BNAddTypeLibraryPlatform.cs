using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNAddTypeLibraryPlatform(BNTypeLibrary* lib, BNPlatform* platform)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAddTypeLibraryPlatform"
        )]
		internal static extern void BNAddTypeLibraryPlatform(
			
			// BNTypeLibrary* lib
		    IntPtr lib  , 
			
			// BNPlatform* platform
		    IntPtr platform  
		);
	}
}