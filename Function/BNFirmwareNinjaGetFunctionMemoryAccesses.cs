using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// int32_t BNFirmwareNinjaGetFunctionMemoryAccesses(BNFirmwareNinja* fn, BNFirmwareNinjaFunctionMemoryAccesses*** fma, void** progress, void* progressContext)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFirmwareNinjaGetFunctionMemoryAccesses"
        )]
		internal static extern int BNFirmwareNinjaGetFunctionMemoryAccesses(
			
			// BNFirmwareNinja* fn
		    IntPtr fn  , 
			
			// BNFirmwareNinjaFunctionMemoryAccesses*** fma
		    IntPtr fma  , 
			
			// void** progress
		    IntPtr progress  , 
			
			// void* progressContext
		    IntPtr progressContext  
			
		);
	}
}