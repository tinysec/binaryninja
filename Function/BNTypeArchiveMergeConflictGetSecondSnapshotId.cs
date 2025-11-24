using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNTypeArchiveMergeConflictGetSecondSnapshotId(BNTypeArchiveMergeConflict* conflict)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNTypeArchiveMergeConflictGetSecondSnapshotId"
        )]
		internal static extern IntPtr BNTypeArchiveMergeConflictGetSecondSnapshotId(
			
			// BNTypeArchiveMergeConflict* conflict
		    IntPtr conflict  
			
		);
	}
}