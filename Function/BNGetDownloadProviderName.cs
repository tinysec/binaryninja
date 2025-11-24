using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNGetDownloadProviderName(BNDownloadProvider* provider)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetDownloadProviderName"
        )]
		internal static extern IntPtr BNGetDownloadProviderName(
			
			// BNDownloadProvider* provider
		    IntPtr provider  
			
		);
	}
}