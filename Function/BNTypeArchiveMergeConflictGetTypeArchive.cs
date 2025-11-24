using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNTypeArchive* BNTypeArchiveMergeConflictGetTypeArchive(BNTypeArchiveMergeConflict* conflict)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNTypeArchiveMergeConflictGetTypeArchive"
        )]
		internal static extern IntPtr BNTypeArchiveMergeConflictGetTypeArchive(
			
			// BNTypeArchiveMergeConflict* conflict
		    IntPtr conflict  
			
		);
	}
}