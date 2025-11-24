using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeFirmwareNinja(BNFirmwareNinja* fn)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeFirmwareNinja"
        )]
		internal static extern void BNFreeFirmwareNinja(
			
			// BNFirmwareNinja* fn
		    IntPtr fn  
			
		);
	}
}