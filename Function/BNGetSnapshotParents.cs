using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNSnapshot** BNGetSnapshotParents(BNSnapshot* snapshot, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetSnapshotParents"
        )]
		internal static extern IntPtr BNGetSnapshotParents(
			
			// BNSnapshot* snapshot
		    IntPtr snapshot  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}