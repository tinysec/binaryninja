using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNWebsocketClient* BNCreateWebsocketProviderClient(BNWebsocketProvider* provider)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreateWebsocketProviderClient"
        )]
		internal static extern IntPtr BNCreateWebsocketProviderClient(
			
			// BNWebsocketProvider* provider
		    IntPtr provider  
		);
	}
}