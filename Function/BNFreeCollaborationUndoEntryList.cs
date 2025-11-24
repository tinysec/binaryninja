using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeCollaborationUndoEntryList(BNCollaborationUndoEntry** entries, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeCollaborationUndoEntryList"
        )]
		internal static extern void BNFreeCollaborationUndoEntryList(
			
			// BNCollaborationUndoEntry** entries
		    IntPtr entries  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}