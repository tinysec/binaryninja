using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNCollaborationPermissionSetLevel(BNCollaborationPermission* permission, BNCollaborationPermissionLevel level)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCollaborationPermissionSetLevel"
        )]
		internal static extern void BNCollaborationPermissionSetLevel(
			
			// BNCollaborationPermission* permission
		    IntPtr permission  , 
			
			// BNCollaborationPermissionLevel level
		    CollaborationPermissionLevel level  
		);
	}
}