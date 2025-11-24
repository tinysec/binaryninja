using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeTypeArchiveReference(BNTypeArchive* archive)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreeTypeArchiveReference"
        )]
		internal static extern void BNFreeTypeArchiveReference(
			
			// BNTypeArchive* archive
		    IntPtr archive  
		);
	}
}