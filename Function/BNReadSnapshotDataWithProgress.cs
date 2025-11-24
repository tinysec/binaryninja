using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNKeyValueStore* BNReadSnapshotDataWithProgress(BNSnapshot* snapshot, void* ctxt, void** progress)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNReadSnapshotDataWithProgress"
        )]
		internal static extern IntPtr BNReadSnapshotDataWithProgress(
			
			// BNSnapshot* snapshot
		    IntPtr snapshot  , 
			
			// void* ctxt
		    IntPtr ctxt  , 
			
			// void** progress
		    IntPtr progress  
			
		);
	}
}