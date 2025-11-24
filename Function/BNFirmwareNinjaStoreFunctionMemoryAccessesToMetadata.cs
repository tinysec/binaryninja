using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFirmwareNinjaStoreFunctionMemoryAccessesToMetadata(BNFirmwareNinja* fn, BNFirmwareNinjaFunctionMemoryAccesses** fma, int32_t size)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFirmwareNinjaStoreFunctionMemoryAccessesToMetadata"
        )]
		internal static extern void BNFirmwareNinjaStoreFunctionMemoryAccessesToMetadata(
			
			// BNFirmwareNinja* fn
		    IntPtr fn  , 
			
			// BNFirmwareNinjaFunctionMemoryAccesses** fma
		    IntPtr fma  , 
			
			// int32_t size
		    int size  
			
		);
	}
}