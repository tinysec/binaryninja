using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNDownloadInstance* BNCreateDownloadProviderInstance(BNDownloadProvider* provider)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreateDownloadProviderInstance"
        )]
		internal static extern IntPtr BNCreateDownloadProviderInstance(
			
			// BNDownloadProvider* provider
		    IntPtr provider  
		);
	}
}