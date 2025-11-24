using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeMemoryUsageInfo(BNMemoryUsageInfo* info, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeMemoryUsageInfo"
        )]
		internal static extern void BNFreeMemoryUsageInfo(
			
			// BNMemoryUsageInfo* info
		    IntPtr info  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}