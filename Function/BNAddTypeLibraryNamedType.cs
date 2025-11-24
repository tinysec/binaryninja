using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNAddTypeLibraryNamedType(BNTypeLibrary* lib, BNQualifiedName* name, BNType* type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAddTypeLibraryNamedType"
        )]
		internal static extern void BNAddTypeLibraryNamedType(
			
			// BNTypeLibrary* lib
		    IntPtr lib  , 
			
			// BNQualifiedName* name
		    in BNQualifiedName name  , 
			
			// BNType* type
		    IntPtr type  
		);
	}
}