using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNClearTypeLibraryPlatforms(BNTypeLibrary* lib)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNClearTypeLibraryPlatforms"
        )]
		internal static extern void BNClearTypeLibraryPlatforms(
			
			// BNTypeLibrary* lib
		    IntPtr lib  
		);
	}
}