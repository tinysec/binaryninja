using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRemoteProject* BNCollaborationPermissionGetProject(BNCollaborationPermission* permission)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCollaborationPermissionGetProject"
        )]
		internal static extern IntPtr BNCollaborationPermissionGetProject(
			
			// BNCollaborationPermission* permission
		    IntPtr permission  
		);
	}
}