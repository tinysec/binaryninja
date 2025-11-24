using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNType* BNGetPlatformSystemCallType(BNPlatform* platform, uint32_t number)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetPlatformSystemCallType"
        )]
		internal static extern IntPtr BNGetPlatformSystemCallType(
			
			// BNPlatform* platform
		    IntPtr platform  , 
			
			// uint32_t number
		    uint number  
			
		);
	}
}