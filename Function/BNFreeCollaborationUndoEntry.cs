using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeCollaborationUndoEntry(BNCollaborationUndoEntry* entry)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeCollaborationUndoEntry"
        )]
		internal static extern void BNFreeCollaborationUndoEntry(
			
			// BNCollaborationUndoEntry* entry
		    IntPtr entry  
			
		);
	}
}