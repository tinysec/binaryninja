using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRemoteProject* BNCollaborationSnapshotGetProject(BNCollaborationSnapshot* snapshot)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCollaborationSnapshotGetProject"
        )]
		internal static extern IntPtr BNCollaborationSnapshotGetProject(
			
			// BNCollaborationSnapshot* snapshot
		    IntPtr snapshot  
		);
	}
}