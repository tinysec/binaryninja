using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeDownloadProviderList(BNDownloadProvider** providers)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeDownloadProviderList"
        )]
		internal static extern void BNFreeDownloadProviderList(
			
			// BNDownloadProvider** providers
		    IntPtr providers  
			
		);
	}
}