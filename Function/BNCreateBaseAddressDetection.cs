using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNBaseAddressDetection* BNCreateBaseAddressDetection(BNBinaryView* view)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreateBaseAddressDetection"
        )]
		internal static extern IntPtr BNCreateBaseAddressDetection(
			
			// BNBinaryView* view
		    IntPtr view  
		);
	}
}