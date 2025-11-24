using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNCollaborationSnapshot* BNCollaborationUndoEntryGetSnapshot(BNCollaborationUndoEntry* undoEntry)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCollaborationUndoEntryGetSnapshot"
        )]
		internal static extern IntPtr BNCollaborationUndoEntryGetSnapshot(
			
			// BNCollaborationUndoEntry* undoEntry
		    IntPtr undoEntry  
		);
	}
}