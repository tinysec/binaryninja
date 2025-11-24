using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// int32_t BNRemoteRequest(BNRemote* remote, void* request, void* ret)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRemoteRequest"
        )]
		internal static extern int BNRemoteRequest(
			
			// BNRemote* remote
		    IntPtr remote  , 
			
			// void* request
		    IntPtr request  , 
			
			// void* ret
		    IntPtr ret  
			
		);
	}
}