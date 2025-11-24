using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNProjectFile* BNExternalLibraryGetBackingFile(BNExternalLibrary* lib)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNExternalLibraryGetBackingFile"
        )]
		internal static extern IntPtr BNExternalLibraryGetBackingFile(
			
			// BNExternalLibrary* lib
		    IntPtr lib  
			
		);
	}
}