using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNUndoAction** BNUndoEntryGetActions(BNUndoEntry* entry, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNUndoEntryGetActions"
        )]
		internal static extern IntPtr BNUndoEntryGetActions(
			
			// BNUndoEntry* entry
		    IntPtr entry  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}