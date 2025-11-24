using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRemoteFile* BNCollaborationGetRemoteFileForLocalTypeArchive(BNTypeArchive* archive)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCollaborationGetRemoteFileForLocalTypeArchive"
        )]
		internal static extern IntPtr BNCollaborationGetRemoteFileForLocalTypeArchive(
			
			// BNTypeArchive* archive
		    IntPtr archive  
		);
	}
}