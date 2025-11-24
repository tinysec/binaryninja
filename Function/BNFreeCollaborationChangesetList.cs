using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeCollaborationChangesetList(BNCollaborationChangeset** changesets, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeCollaborationChangesetList"
        )]
		internal static extern void BNFreeCollaborationChangesetList(
			
			// BNCollaborationChangeset** changesets
		    IntPtr changesets  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}