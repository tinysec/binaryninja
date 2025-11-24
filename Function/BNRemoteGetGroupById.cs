using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNCollaborationGroup* BNRemoteGetGroupById(BNRemote* remote, uint64_t id)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRemoteGetGroupById"
        )]
		internal static extern IntPtr BNRemoteGetGroupById(
			
			// BNRemote* remote
		    IntPtr remote  , 
			
			// uint64_t id
		    ulong id  
			
		);
	}
}