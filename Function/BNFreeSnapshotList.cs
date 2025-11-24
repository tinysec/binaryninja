using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeSnapshotList(BNSnapshot** snapshots, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeSnapshotList"
        )]
		internal static extern void BNFreeSnapshotList(
			
			// BNSnapshot** snapshots
		    IntPtr snapshots  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}