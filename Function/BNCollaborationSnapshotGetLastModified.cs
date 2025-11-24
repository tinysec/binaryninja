using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// int64_t BNCollaborationSnapshotGetLastModified(BNCollaborationSnapshot* snapshot)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCollaborationSnapshotGetLastModified"
        )]
		internal static extern long BNCollaborationSnapshotGetLastModified(
			
			// BNCollaborationSnapshot* snapshot
		    IntPtr snapshot  
		);
	}
}