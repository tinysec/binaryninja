using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNCollaborationPermission** BNRemoteProjectGetGroupPermissions(BNRemoteProject* project, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRemoteProjectGetGroupPermissions"
        )]
		internal static extern IntPtr BNRemoteProjectGetGroupPermissions(
			
			// BNRemoteProject* project
		    IntPtr project  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}