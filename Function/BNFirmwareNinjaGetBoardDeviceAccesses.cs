using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// int32_t BNFirmwareNinjaGetBoardDeviceAccesses(BNFirmwareNinja* fn, BNFirmwareNinjaFunctionMemoryAccesses** fma, int32_t size, BNFirmwareNinjaDeviceAccesses** accesses, BNArchitecture* arch)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFirmwareNinjaGetBoardDeviceAccesses"
        )]
		internal static extern int BNFirmwareNinjaGetBoardDeviceAccesses(
			
			// BNFirmwareNinja* fn
		    IntPtr fn  , 
			
			// BNFirmwareNinjaFunctionMemoryAccesses** fma
		    IntPtr fma  , 
			
			// int32_t size
		    int size  , 
			
			// BNFirmwareNinjaDeviceAccesses** accesses
		    IntPtr accesses  , 
			
			// BNArchitecture* arch
		    IntPtr arch  
			
		);
	}
}