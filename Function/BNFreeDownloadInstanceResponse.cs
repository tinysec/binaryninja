using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeDownloadInstanceResponse(BNDownloadInstanceResponse* response)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeDownloadInstanceResponse"
        )]
		internal static extern void BNFreeDownloadInstanceResponse(
			
			// BNDownloadInstanceResponse* response
		    IntPtr response  
			
		);
	}
}