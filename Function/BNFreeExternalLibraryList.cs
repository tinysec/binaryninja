using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeExternalLibraryList(BNExternalLibrary** libs, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreeExternalLibraryList"
        )]
		internal static extern void BNFreeExternalLibraryList(
			
			// BNExternalLibrary** libs
		    IntPtr libs  , 
			
			// uint64_t count
		    ulong count  
		);
	}
}