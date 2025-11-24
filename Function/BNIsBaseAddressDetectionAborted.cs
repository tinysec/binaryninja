using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// bool BNIsBaseAddressDetectionAborted(BNBaseAddressDetection* bad)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNIsBaseAddressDetectionAborted"
        )]
		internal static extern bool BNIsBaseAddressDetectionAborted(
			
			// BNBaseAddressDetection* bad
		    IntPtr bad  
			
		);
	}
}