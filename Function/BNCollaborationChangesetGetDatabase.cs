using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNDatabase* BNCollaborationChangesetGetDatabase(BNCollaborationChangeset* changeset)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCollaborationChangesetGetDatabase"
        )]
		internal static extern IntPtr BNCollaborationChangesetGetDatabase(
			
			// BNCollaborationChangeset* changeset
		    IntPtr changeset  
		);
	}
}