using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNAddBinaryViewTypeLibrary(BNBinaryView* view, BNTypeLibrary* lib)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAddBinaryViewTypeLibrary"
        )]
		internal static extern void BNAddBinaryViewTypeLibrary(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNTypeLibrary* lib
		    IntPtr lib  
		);
	}
}