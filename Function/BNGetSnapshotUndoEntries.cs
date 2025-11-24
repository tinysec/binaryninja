using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNUndoEntry** BNGetSnapshotUndoEntries(BNSnapshot* snapshot, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetSnapshotUndoEntries"
        )]
		internal static extern IntPtr BNGetSnapshotUndoEntries(
			
			// BNSnapshot* snapshot
		    IntPtr snapshot  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}