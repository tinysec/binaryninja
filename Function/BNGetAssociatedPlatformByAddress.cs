using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNPlatform* BNGetAssociatedPlatformByAddress(BNPlatform* platform, uint64_t* addr)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetAssociatedPlatformByAddress"
        )]
		internal static extern IntPtr BNGetAssociatedPlatformByAddress(
			
			// BNPlatform* platform
		    IntPtr platform  , 
			
			// uint64_t* addr
		    ref ulong addr  
		);
	}
}