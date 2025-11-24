using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRemoteFile* BNCollaborationSnapshotGetFile(BNCollaborationSnapshot* snapshot)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCollaborationSnapshotGetFile"
        )]
		internal static extern IntPtr BNCollaborationSnapshotGetFile(
			
			// BNCollaborationSnapshot* snapshot
		    IntPtr snapshot  
		);
	}
}