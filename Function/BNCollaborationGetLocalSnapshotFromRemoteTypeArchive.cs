using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNCollaborationGetLocalSnapshotFromRemoteTypeArchive(BNCollaborationSnapshot* snapshot, BNTypeArchive* archive)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCollaborationGetLocalSnapshotFromRemoteTypeArchive"
        )]
		internal static extern IntPtr BNCollaborationGetLocalSnapshotFromRemoteTypeArchive(
			
			// BNCollaborationSnapshot* snapshot
		    IntPtr snapshot  , 
			
			// BNTypeArchive* archive
		    IntPtr archive  
		);
	}
}