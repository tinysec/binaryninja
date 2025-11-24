using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRemoteProject** BNRemoteGetProjects(BNRemote* remote, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRemoteGetProjects"
        )]
		internal static extern IntPtr BNRemoteGetProjects(
			
			// BNRemote* remote
		    IntPtr remote  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}