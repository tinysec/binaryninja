using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNTypeArchiveMergeConflictGetFirstSnapshotId(BNTypeArchiveMergeConflict* conflict)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNTypeArchiveMergeConflictGetFirstSnapshotId"
        )]
		internal static extern IntPtr BNTypeArchiveMergeConflictGetFirstSnapshotId(
			
			// BNTypeArchiveMergeConflict* conflict
		    IntPtr conflict  
			
		);
	}
}