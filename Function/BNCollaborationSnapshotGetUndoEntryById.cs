using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNCollaborationUndoEntry* BNCollaborationSnapshotGetUndoEntryById(BNCollaborationSnapshot* snapshot, uint64_t id)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCollaborationSnapshotGetUndoEntryById"
        )]
		internal static extern IntPtr BNCollaborationSnapshotGetUndoEntryById(
			
			// BNCollaborationSnapshot* snapshot
		    IntPtr snapshot  , 
			
			// uint64_t id
		    ulong id  
		);
	}
}