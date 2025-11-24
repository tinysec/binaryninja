using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNCollaborationUndoEntry* BNNewCollaborationUndoEntryReference(BNCollaborationUndoEntry* entry)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNNewCollaborationUndoEntryReference"
        )]
		internal static extern IntPtr BNNewCollaborationUndoEntryReference(
			
			// BNCollaborationUndoEntry* entry
		    IntPtr entry  
			
		);
	}
}