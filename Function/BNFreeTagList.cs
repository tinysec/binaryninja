using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeTagList(BNTag** tags, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeTagList"
        )]
		internal static extern void BNFreeTagList(
			
			// BNTag** tags
		    IntPtr tags  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}