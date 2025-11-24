using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNCollaborationSnapshot* BNNewCollaborationSnapshotReference(BNCollaborationSnapshot* snapshot)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNNewCollaborationSnapshotReference"
        )]
		internal static extern IntPtr BNNewCollaborationSnapshotReference(
			
			// BNCollaborationSnapshot* snapshot
		    IntPtr snapshot  
			
		);
	}
}