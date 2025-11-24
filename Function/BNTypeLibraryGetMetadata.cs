using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNMetadata* BNTypeLibraryGetMetadata(BNTypeLibrary* lib)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNTypeLibraryGetMetadata"
        )]
		internal static extern IntPtr BNTypeLibraryGetMetadata(
			
			// BNTypeLibrary* lib
		    IntPtr lib  
		);
	}
}