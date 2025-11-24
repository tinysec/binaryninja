using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeProjectFolderList(BNProjectFolder** folders, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeProjectFolderList"
        )]
		internal static extern void BNFreeProjectFolderList(
			
			// BNProjectFolder** folders
		    IntPtr folders  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}