using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetDefaultPlatform(BNBinaryView* view, BNPlatform* platform)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetDefaultPlatform"
        )]
		internal static extern void BNSetDefaultPlatform(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNPlatform* platform
		    IntPtr platform  
			
		);
	}
}