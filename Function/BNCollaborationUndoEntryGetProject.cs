using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRemoteProject* BNCollaborationUndoEntryGetProject(BNCollaborationUndoEntry* undoEntry)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCollaborationUndoEntryGetProject"
        )]
		internal static extern IntPtr BNCollaborationUndoEntryGetProject(
			
			// BNCollaborationUndoEntry* undoEntry
		    IntPtr undoEntry  
		);
	}
}