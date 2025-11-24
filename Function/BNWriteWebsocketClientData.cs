using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNWriteWebsocketClientData(BNWebsocketClient* client, uint8_t* data, uint64_t len)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNWriteWebsocketClientData"
        )]
		internal static extern ulong BNWriteWebsocketClientData(
			
			// BNWebsocketClient* client
		    IntPtr client  , 
			
			// uint8_t* data
		    IntPtr data  , 
			
			// uint64_t len
		    ulong len  
			
		);
	}
}