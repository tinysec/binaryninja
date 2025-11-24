using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// int32_t BNFirmwareNinjaQueryFunctionMemoryAccessesFromMetadata(BNFirmwareNinja* fn, BNFirmwareNinjaFunctionMemoryAccesses*** fma)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFirmwareNinjaQueryFunctionMemoryAccessesFromMetadata"
        )]
		internal static extern int BNFirmwareNinjaQueryFunctionMemoryAccessesFromMetadata(
			
			// BNFirmwareNinja* fn
		    IntPtr fn  , 
			
			// BNFirmwareNinjaFunctionMemoryAccesses*** fma
		    IntPtr fma  
			
		);
	}
}