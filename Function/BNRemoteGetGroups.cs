using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNCollaborationGroup** BNRemoteGetGroups(BNRemote* remote, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRemoteGetGroups"
        )]
		internal static extern IntPtr BNRemoteGetGroups(
			
			// BNRemote* remote
		    IntPtr remote  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}