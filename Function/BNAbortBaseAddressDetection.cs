using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNAbortBaseAddressDetection(BNBaseAddressDetection* bad)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAbortBaseAddressDetection"
        )]
		internal static extern void BNAbortBaseAddressDetection(
			
			// BNBaseAddressDetection* bad
		    IntPtr bad  
		);
	}
}