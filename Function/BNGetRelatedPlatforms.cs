using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNPlatform** BNGetRelatedPlatforms(BNPlatform* platform, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetRelatedPlatforms"
        )]
		internal static extern IntPtr BNGetRelatedPlatforms(
			
			// BNPlatform* platform
		    IntPtr platform  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}