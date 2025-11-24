using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeRemoteFolderList(BNRemoteFolder** folders, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeRemoteFolderList"
        )]
		internal static extern void BNFreeRemoteFolderList(
			
			// BNRemoteFolder** folders
		    IntPtr folders  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}