using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNQualifiedNameAndType* BNGetTypeLibraryNamedTypes(BNTypeLibrary* lib, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetTypeLibraryNamedTypes"
        )]
		internal static extern IntPtr BNGetTypeLibraryNamedTypes(
			
			// BNTypeLibrary* lib
		    IntPtr lib  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}