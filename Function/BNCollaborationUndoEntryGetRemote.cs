using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRemote* BNCollaborationUndoEntryGetRemote(BNCollaborationUndoEntry* undoEntry)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCollaborationUndoEntryGetRemote"
        )]
		internal static extern IntPtr BNCollaborationUndoEntryGetRemote(
			
			// BNCollaborationUndoEntry* undoEntry
		    IntPtr undoEntry  
		);
	}
}