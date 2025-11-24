using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNCollaborationUser** BNRemoteGetUsers(BNRemote* remote, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRemoteGetUsers"
        )]
		internal static extern IntPtr BNRemoteGetUsers(
			
			// BNRemote* remote
		    IntPtr remote  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}