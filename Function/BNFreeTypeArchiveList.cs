using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeTypeArchiveList(BNTypeArchive** archives, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeTypeArchiveList"
        )]
		internal static extern void BNFreeTypeArchiveList(
			
			// BNTypeArchive** archives
		    IntPtr archives  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}