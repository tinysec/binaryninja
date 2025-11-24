using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNCollaborationSnapshotGetAnalysisCacheBuildId(BNCollaborationSnapshot* snapshot)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCollaborationSnapshotGetAnalysisCacheBuildId"
        )]
		internal static extern ulong BNCollaborationSnapshotGetAnalysisCacheBuildId(
			
			// BNCollaborationSnapshot* snapshot
		    IntPtr snapshot  
		);
	}
}