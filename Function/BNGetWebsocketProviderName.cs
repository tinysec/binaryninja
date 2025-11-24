using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNGetWebsocketProviderName(BNWebsocketProvider* provider)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetWebsocketProviderName"
        )]
		internal static extern IntPtr BNGetWebsocketProviderName(
			
			// BNWebsocketProvider* provider
		    IntPtr provider  
			
		);
	}
}