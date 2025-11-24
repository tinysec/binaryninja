using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeCollaborationChangeset(BNCollaborationChangeset* changeset)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeCollaborationChangeset"
        )]
		internal static extern void BNFreeCollaborationChangeset(
			
			// BNCollaborationChangeset* changeset
		    IntPtr changeset  
			
		);
	}
}