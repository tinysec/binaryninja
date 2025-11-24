using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNUndoEntry** BNGetSnapshotUndoEntriesWithProgress(BNSnapshot* snapshot, void* ctxt, void** progress, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetSnapshotUndoEntriesWithProgress"
        )]
		internal static extern IntPtr BNGetSnapshotUndoEntriesWithProgress(
			
			// BNSnapshot* snapshot
		    IntPtr snapshot  , 
			
			// void* ctxt
		    IntPtr ctxt  , 
			
			// void** progress
		    IntPtr progress  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}