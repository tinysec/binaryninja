using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNExternalLibrarySetBackingFile(BNExternalLibrary* lib, BNProjectFile* file)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNExternalLibrarySetBackingFile"
        )]
		internal static extern void BNExternalLibrarySetBackingFile(
			
			// BNExternalLibrary* lib
		    IntPtr lib  , 
			
			// BNProjectFile* file
		    IntPtr file  
			
		);
	}
}