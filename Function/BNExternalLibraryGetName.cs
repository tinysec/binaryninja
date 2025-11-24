using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// char* BNExternalLibraryGetName(BNExternalLibrary* lib)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNExternalLibraryGetName"
        )]
		internal static extern IntPtr BNExternalLibraryGetName(
			
			// BNExternalLibrary* lib
		    IntPtr lib  
		);
	}
}