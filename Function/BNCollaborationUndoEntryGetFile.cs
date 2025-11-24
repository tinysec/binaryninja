using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRemoteFile* BNCollaborationUndoEntryGetFile(BNCollaborationUndoEntry* undoEntry)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCollaborationUndoEntryGetFile"
        )]
		internal static extern IntPtr BNCollaborationUndoEntryGetFile(
			
			// BNCollaborationUndoEntry* undoEntry
		    IntPtr undoEntry  
		);
	}
}