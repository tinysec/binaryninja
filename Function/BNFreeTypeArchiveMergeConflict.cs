using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeTypeArchiveMergeConflict(BNTypeArchiveMergeConflict* conflict)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeTypeArchiveMergeConflict"
        )]
		internal static extern void BNFreeTypeArchiveMergeConflict(
			
			// BNTypeArchiveMergeConflict* conflict
		    IntPtr conflict  
			
		);
	}
}