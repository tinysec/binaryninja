using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreePlatformOSList(const char** list, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreePlatformOSList"
        )]
		internal static extern void BNFreePlatformOSList(
			
			// char** list
		    IntPtr list  , 
			
			// uint64_t count
		    ulong count  
		);
	}
}