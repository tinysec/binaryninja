using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFirmwareNinjaFreeBoardDeviceAccesses(BNFirmwareNinjaDeviceAccesses* accesses, int32_t size)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFirmwareNinjaFreeBoardDeviceAccesses"
        )]
		internal static extern void BNFirmwareNinjaFreeBoardDeviceAccesses(
			
			// BNFirmwareNinjaDeviceAccesses* accesses
		    IntPtr accesses  , 
			
			// int32_t size
		    int size  
			
		);
	}
}