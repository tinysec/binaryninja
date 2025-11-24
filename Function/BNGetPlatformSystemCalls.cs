using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNSystemCallInfo* BNGetPlatformSystemCalls(BNPlatform* platform, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetPlatformSystemCalls"
        )]
		internal static extern IntPtr BNGetPlatformSystemCalls(
			
			// BNPlatform* platform
		    IntPtr platform  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}