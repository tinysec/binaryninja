using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeRepositoryPluginList(BNRepoPlugin** r)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeRepositoryPluginList"
        )]
		internal static extern void BNFreeRepositoryPluginList(
			
			// BNRepoPlugin** r
		    IntPtr r  
			
		);
	}
}