using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNTypeLibrary* BNNewTypeLibraryReference(BNTypeLibrary* lib)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNNewTypeLibraryReference"
        )]
		internal static extern IntPtr BNNewTypeLibraryReference(
			
			// BNTypeLibrary* lib
		    IntPtr lib  
			
		);
	}
}