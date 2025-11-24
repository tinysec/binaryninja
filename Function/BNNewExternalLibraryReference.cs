using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNExternalLibrary* BNNewExternalLibraryReference(BNExternalLibrary* lib)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNNewExternalLibraryReference"
        )]
		internal static extern IntPtr BNNewExternalLibraryReference(
			
			// BNExternalLibrary* lib
		    IntPtr lib  
			
		);
	}
}