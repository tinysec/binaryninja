using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNAddRelatedPlatform(BNPlatform* platform, BNArchitecture* arch, BNPlatform* related)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAddRelatedPlatform"
        )]
		internal static extern void BNAddRelatedPlatform(
			
			// BNPlatform* platform
		    IntPtr platform  , 
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// BNPlatform* related
		    IntPtr related  
		);
	}
}