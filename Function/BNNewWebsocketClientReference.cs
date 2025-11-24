using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNWebsocketClient* BNNewWebsocketClientReference(BNWebsocketClient* client)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNNewWebsocketClientReference"
        )]
		internal static extern IntPtr BNNewWebsocketClientReference(
			
			// BNWebsocketClient* client
		    IntPtr client  
			
		);
	}
}