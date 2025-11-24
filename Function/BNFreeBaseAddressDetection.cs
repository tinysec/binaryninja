using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeBaseAddressDetection(BNBaseAddressDetection* bad)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeBaseAddressDetection"
        )]
		internal static extern void BNFreeBaseAddressDetection(
			
			// BNBaseAddressDetection* bad
		    IntPtr bad  
			
		);
	}
}