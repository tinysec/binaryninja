using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNCollaborationChangeset* BNNewCollaborationChangesetReference(BNCollaborationChangeset* changeset)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNNewCollaborationChangesetReference"
        )]
		internal static extern IntPtr BNNewCollaborationChangesetReference(
			
			// BNCollaborationChangeset* changeset
		    IntPtr changeset  
			
		);
	}
}