using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNType* BNGetTypeLibraryNamedObject(BNTypeLibrary* lib, BNQualifiedName* name)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetTypeLibraryNamedObject"
        )]
		internal static extern IntPtr BNGetTypeLibraryNamedObject(
			
			// BNTypeLibrary* lib
		    IntPtr lib  , 
			
			// BNQualifiedName* name
		    in BNQualifiedName name  
		);
	}
}