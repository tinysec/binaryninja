using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNCollaborationSnapshotGetAuthor(BNCollaborationSnapshot* snapshot)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCollaborationSnapshotGetAuthor"
        )]
		internal static extern IntPtr BNCollaborationSnapshotGetAuthor(
			
			// BNCollaborationSnapshot* snapshot
		    IntPtr snapshot  
		);
	}
}