using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreePlatformList(BNPlatform** platform, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreePlatformList"
        )]
		internal static extern void BNFreePlatformList(
			
			// BNPlatform** platform
		    IntPtr platform  , 
			
			// uint64_t count
		    ulong count  
		);
	}
}