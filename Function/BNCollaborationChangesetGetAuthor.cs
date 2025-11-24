using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNCollaborationUser* BNCollaborationChangesetGetAuthor(BNCollaborationChangeset* changeset)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCollaborationChangesetGetAuthor"
        )]
		internal static extern IntPtr BNCollaborationChangesetGetAuthor(
			
			// BNCollaborationChangeset* changeset
		    IntPtr changeset  
		);
	}
}