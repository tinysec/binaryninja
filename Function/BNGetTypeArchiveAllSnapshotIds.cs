using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char** BNGetTypeArchiveAllSnapshotIds(BNTypeArchive* archive, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetTypeArchiveAllSnapshotIds"
        )]
		internal static extern IntPtr BNGetTypeArchiveAllSnapshotIds(
			
			// BNTypeArchive* archive
		    IntPtr archive  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}