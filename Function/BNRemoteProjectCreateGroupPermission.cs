using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNCollaborationPermission* BNRemoteProjectCreateGroupPermission(BNRemoteProject* project, int64_t groupId, BNCollaborationPermissionLevel level, void** progress, void* progressContext)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRemoteProjectCreateGroupPermission"
        )]
		internal static extern IntPtr BNRemoteProjectCreateGroupPermission(
			
			// BNRemoteProject* project
		    IntPtr project  , 
			
			// int64_t groupId
		    long groupId  , 
			
			// BNCollaborationPermissionLevel level
		    CollaborationPermissionLevel level  , 
			
			// void** progress
		    IntPtr progress  , 
			
			// void* progressContext
		    IntPtr progressContext  
			
		);
	}
}