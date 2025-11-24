using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeProjectFileList(BNProjectFile** files, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeProjectFileList"
        )]
		internal static extern void BNFreeProjectFileList(
			
			// BNProjectFile** files
		    IntPtr files  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}