using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNType* BNBinaryViewImportTypeLibraryObject(BNBinaryView* view, BNTypeLibrary** lib, BNQualifiedName* name)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNBinaryViewImportTypeLibraryObject"
        )]
		internal static extern IntPtr BNBinaryViewImportTypeLibraryObject(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNTypeLibrary** lib
		    ref IntPtr lib  , 
			
			// BNQualifiedName* name
		    in BNQualifiedName name  
		);
	}
}