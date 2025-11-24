using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNType* BNBinaryViewImportTypeLibraryType(BNBinaryView* view, BNTypeLibrary** lib, BNQualifiedName* name)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNBinaryViewImportTypeLibraryType"
        )]
		internal static extern IntPtr BNBinaryViewImportTypeLibraryType(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNTypeLibrary** lib
		    IntPtr lib  , 
			
			// BNQualifiedName* name
		    in BNQualifiedName? name  
		);
	}
}