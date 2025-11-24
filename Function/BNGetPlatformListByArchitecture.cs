using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNPlatform** BNGetPlatformListByArchitecture(BNArchitecture* arch, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetPlatformListByArchitecture"
        )]
		internal static extern IntPtr BNGetPlatformListByArchitecture(
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}