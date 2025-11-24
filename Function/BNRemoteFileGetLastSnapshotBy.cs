using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNRemoteFileGetLastSnapshotBy(BNRemoteFile* file)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRemoteFileGetLastSnapshotBy"
        )]
		internal static extern IntPtr BNRemoteFileGetLastSnapshotBy(
			
			// BNRemoteFile* file
		    IntPtr file  
			
		);
	}
}