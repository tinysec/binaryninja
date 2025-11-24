using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNGetAutoPlatformTypeIdSource(BNPlatform* platform)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetAutoPlatformTypeIdSource"
        )]
		internal static extern IntPtr BNGetAutoPlatformTypeIdSource(
			
			// BNPlatform* platform
		    IntPtr platform  
			
		);
	}
}