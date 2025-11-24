using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// int64_t* BNCollaborationChangesetGetSnapshotIds(BNCollaborationChangeset* changeset, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCollaborationChangesetGetSnapshotIds"
        )]
		internal static extern IntPtr BNCollaborationChangesetGetSnapshotIds(
			
			// BNCollaborationChangeset* changeset
		    IntPtr changeset  , 
			
			// uint64_t* count
		    IntPtr count  
		);
	}
}