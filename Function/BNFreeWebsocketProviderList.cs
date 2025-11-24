using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeWebsocketProviderList(BNWebsocketProvider** providers)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeWebsocketProviderList"
        )]
		internal static extern void BNFreeWebsocketProviderList(
			
			// BNWebsocketProvider** providers
		    IntPtr providers  
			
		);
	}
}