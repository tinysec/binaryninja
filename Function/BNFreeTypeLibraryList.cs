using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeTypeLibraryList(BNTypeLibrary** lib, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreeTypeLibraryList"
        )]
		internal static extern void BNFreeTypeLibraryList(
			
			// BNTypeLibrary** lib
		    IntPtr lib  , 
			
			// uint64_t count
		    ulong count  
		);
	}
}