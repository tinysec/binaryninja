using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNCollaborationPermissionLevel BNCollaborationPermissionGetLevel(BNCollaborationPermission* permission)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCollaborationPermissionGetLevel"
        )]
		internal static extern CollaborationPermissionLevel BNCollaborationPermissionGetLevel(
			
			// BNCollaborationPermission* permission
		    IntPtr permission  
		);
	}
}