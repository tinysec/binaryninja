using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRemoteFile* BNCollaborationChangesetGetFile(BNCollaborationChangeset* changeset)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCollaborationChangesetGetFile"
        )]
		internal static extern IntPtr BNCollaborationChangesetGetFile(
			
			// BNCollaborationChangeset* changeset
		    IntPtr changeset  
		);
	}
}