using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNCollaborationUndoEntryGetId(BNCollaborationUndoEntry* undoEntry)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCollaborationUndoEntryGetId"
        )]
		internal static extern ulong BNCollaborationUndoEntryGetId(
			
			// BNCollaborationUndoEntry* undoEntry
		    IntPtr undoEntry  
		);
	}
}