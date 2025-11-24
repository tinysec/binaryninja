using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNCollaborationSnapshot** BNRemoteFileGetSnapshots(BNRemoteFile* file, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRemoteFileGetSnapshots"
        )]
		internal static extern IntPtr BNRemoteFileGetSnapshots(
			
			// BNRemoteFile* file
		    IntPtr file  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}