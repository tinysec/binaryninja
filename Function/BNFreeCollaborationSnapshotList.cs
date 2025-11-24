using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeCollaborationSnapshotList(BNCollaborationSnapshot** snapshots, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeCollaborationSnapshotList"
        )]
		internal static extern void BNFreeCollaborationSnapshotList(
			
			// BNCollaborationSnapshot** snapshots
		    IntPtr snapshots  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}