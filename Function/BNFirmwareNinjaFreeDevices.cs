using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFirmwareNinjaFreeDevices(BNFirmwareNinjaDevice* devices, int32_t size)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFirmwareNinjaFreeDevices"
        )]
		internal static extern void BNFirmwareNinjaFreeDevices(
			
			// BNFirmwareNinjaDevice* devices
		    IntPtr devices  , 
			
			// int32_t size
		    int size  
			
		);
	}
}