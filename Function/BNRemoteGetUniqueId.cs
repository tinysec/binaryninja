using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNRemoteGetUniqueId(BNRemote* remote)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRemoteGetUniqueId"
        )]
		internal static extern IntPtr BNRemoteGetUniqueId(
			
			// BNRemote* remote
		    IntPtr remote  
			
		);
	}
}