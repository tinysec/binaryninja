using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNTypeContainer* BNGetTypeLibraryTypeContainer(BNTypeLibrary* lib)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetTypeLibraryTypeContainer"
        )]
		internal static extern IntPtr BNGetTypeLibraryTypeContainer(
			
			// BNTypeLibrary* lib
		    IntPtr lib  
		);
	}
}