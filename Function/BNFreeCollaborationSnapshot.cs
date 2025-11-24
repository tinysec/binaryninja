using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeCollaborationSnapshot(BNCollaborationSnapshot* snapshot)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeCollaborationSnapshot"
        )]
		internal static extern void BNFreeCollaborationSnapshot(
			
			// BNCollaborationSnapshot* snapshot
		    IntPtr snapshot  
			
		);
	}
}