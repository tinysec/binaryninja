using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNBinaryViewExportTypeToTypeLibrary(BNBinaryView* view, BNTypeLibrary* lib, BNQualifiedName* name, BNType* type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNBinaryViewExportTypeToTypeLibrary"
        )]
		internal static extern void BNBinaryViewExportTypeToTypeLibrary(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNTypeLibrary* lib
		    IntPtr lib  , 
			
			// BNQualifiedName* name
		    in BNQualifiedName name  , 
			
			// BNType* type
		    IntPtr type  
		);
	}
}