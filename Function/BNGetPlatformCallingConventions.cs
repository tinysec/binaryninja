using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNCallingConvention** BNGetPlatformCallingConventions(BNPlatform* platform, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetPlatformCallingConventions"
        )]
		internal static extern IntPtr BNGetPlatformCallingConventions(
			
			// BNPlatform* platform
		    IntPtr platform  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}