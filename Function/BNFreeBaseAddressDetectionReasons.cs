using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeBaseAddressDetectionReasons(BNBaseAddressDetectionReason* reasons)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeBaseAddressDetectionReasons"
        )]
		internal static extern void BNFreeBaseAddressDetectionReasons(
			
			// BNBaseAddressDetectionReason* reasons
		    IntPtr reasons  
			
		);
	}
}