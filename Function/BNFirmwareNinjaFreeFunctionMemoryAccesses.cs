using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFirmwareNinjaFreeFunctionMemoryAccesses(BNFirmwareNinjaFunctionMemoryAccesses** fma, int32_t size)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFirmwareNinjaFreeFunctionMemoryAccesses"
        )]
		internal static extern void BNFirmwareNinjaFreeFunctionMemoryAccesses(
			
			// BNFirmwareNinjaFunctionMemoryAccesses** fma
		    IntPtr fma  , 
			
			// int32_t size
		    int size  
			
		);
	}
}