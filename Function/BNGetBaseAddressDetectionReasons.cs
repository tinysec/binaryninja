using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNBaseAddressDetectionReason* BNGetBaseAddressDetectionReasons(BNBaseAddressDetection* bad, uint64_t baseAddress, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetBaseAddressDetectionReasons"
        )]
		internal static extern IntPtr BNGetBaseAddressDetectionReasons(
			
			// BNBaseAddressDetection* bad
		    IntPtr bad  , 
			
			// uint64_t baseAddress
		    ulong baseAddress  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}