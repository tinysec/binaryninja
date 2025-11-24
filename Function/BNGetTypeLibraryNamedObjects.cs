using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNQualifiedNameAndType* BNGetTypeLibraryNamedObjects(BNTypeLibrary* lib, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetTypeLibraryNamedObjects"
        )]
		internal static extern IntPtr BNGetTypeLibraryNamedObjects(
			
			// BNTypeLibrary* lib
		    IntPtr lib  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}