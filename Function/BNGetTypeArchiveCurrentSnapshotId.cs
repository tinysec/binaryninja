using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNGetTypeArchiveCurrentSnapshotId(BNTypeArchive* archive)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetTypeArchiveCurrentSnapshotId"
        )]
		internal static extern IntPtr BNGetTypeArchiveCurrentSnapshotId(
			
			// BNTypeArchive* archive
		    IntPtr archive  
			
		);
	}
}