using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNDataBuffer* BNGetSnapshotFileContentsHash(BNSnapshot* snapshot)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetSnapshotFileContentsHash"
        )]
		internal static extern IntPtr BNGetSnapshotFileContentsHash(
			
			// BNSnapshot* snapshot
		    IntPtr snapshot  
			
		);
	}
}