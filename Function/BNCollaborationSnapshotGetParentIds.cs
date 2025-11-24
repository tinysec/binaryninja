using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char** BNCollaborationSnapshotGetParentIds(BNCollaborationSnapshot* snapshot, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCollaborationSnapshotGetParentIds"
        )]
		internal static extern IntPtr BNCollaborationSnapshotGetParentIds(
			
			// BNCollaborationSnapshot* snapshot
		    IntPtr snapshot  , 
			
			// uint64_t* count
		    IntPtr count  
		);
	}
}