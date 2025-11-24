using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNCollaborationPermissionGetUrl(BNCollaborationPermission* permission)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCollaborationPermissionGetUrl"
        )]
		internal static extern IntPtr BNCollaborationPermissionGetUrl(
			
			// BNCollaborationPermission* permission
		    IntPtr permission  
		);
	}
}