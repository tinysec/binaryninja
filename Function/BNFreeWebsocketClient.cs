using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeWebsocketClient(BNWebsocketClient* client)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeWebsocketClient"
        )]
		internal static extern void BNFreeWebsocketClient(
			
			// BNWebsocketClient* client
		    IntPtr client  
			
		);
	}
}