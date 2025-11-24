using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// int32_t BNRemoteGetServerVersion(BNRemote* remote)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRemoteGetServerVersion"
        )]
		internal static extern int BNRemoteGetServerVersion(
			
			// BNRemote* remote
		    IntPtr remote  
			
		);
	}
}