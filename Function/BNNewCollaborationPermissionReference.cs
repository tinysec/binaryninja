using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNCollaborationPermission* BNNewCollaborationPermissionReference(BNCollaborationPermission* permission)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNNewCollaborationPermissionReference"
        )]
		internal static extern IntPtr BNNewCollaborationPermissionReference(
			
			// BNCollaborationPermission* permission
		    IntPtr permission  
			
		);
	}
}