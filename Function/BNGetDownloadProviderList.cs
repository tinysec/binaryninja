using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNDownloadProvider** BNGetDownloadProviderList(uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetDownloadProviderList"
        )]
		internal static extern IntPtr BNGetDownloadProviderList(
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}