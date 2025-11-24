using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFirmwareNinjaFreeSections(BNFirmwareNinjaSection* sections, int32_t size)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFirmwareNinjaFreeSections"
        )]
		internal static extern void BNFirmwareNinjaFreeSections(
			
			// BNFirmwareNinjaSection* sections
		    IntPtr sections  , 
			
			// int32_t size
		    int size  
			
		);
	}
}