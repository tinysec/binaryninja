using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeFirmwareNinjaRelationship(BNFirmwareNinjaRelationship* rel)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeFirmwareNinjaRelationship"
        )]
		internal static extern void BNFreeFirmwareNinjaRelationship(
			
			// BNFirmwareNinjaRelationship* rel
		    IntPtr rel  
			
		);
	}
}