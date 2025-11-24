using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeCollaborationPermissionList(BNCollaborationPermission** permissions, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeCollaborationPermissionList"
        )]
		internal static extern void BNFreeCollaborationPermissionList(
			
			// BNCollaborationPermission** permissions
		    IntPtr permissions  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}