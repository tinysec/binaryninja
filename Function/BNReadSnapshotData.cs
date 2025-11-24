using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNKeyValueStore* BNReadSnapshotData(BNSnapshot* snapshot)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNReadSnapshotData"
        )]
		internal static extern IntPtr BNReadSnapshotData(
			
			// BNSnapshot* snapshot
		    IntPtr snapshot  
			
		);
	}
}