using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNCollaborationSnapshot** BNCollaborationSnapshotGetParents(BNCollaborationSnapshot* snapshot, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCollaborationSnapshotGetParents"
        )]
		internal static extern IntPtr BNCollaborationSnapshotGetParents(
			
			// BNCollaborationSnapshot* snapshot
		    IntPtr snapshot  , 
			
			// uint64_t* count
		    IntPtr count  
		);
	}
}