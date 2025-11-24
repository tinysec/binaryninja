using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNPlatform* BNGetRelatedPlatform(BNPlatform* platform, BNArchitecture* arch)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetRelatedPlatform"
        )]
		internal static extern IntPtr BNGetRelatedPlatform(
			
			// BNPlatform* platform
		    IntPtr platform  , 
			
			// BNArchitecture* arch
		    IntPtr arch  
		);
	}
}