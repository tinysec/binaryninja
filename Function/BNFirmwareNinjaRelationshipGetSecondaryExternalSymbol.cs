using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNFirmwareNinjaRelationshipGetSecondaryExternalSymbol(BNFirmwareNinjaRelationship* rel)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFirmwareNinjaRelationshipGetSecondaryExternalSymbol"
        )]
		internal static extern IntPtr BNFirmwareNinjaRelationshipGetSecondaryExternalSymbol(
			
			// BNFirmwareNinjaRelationship* rel
		    IntPtr rel  
			
		);
	}
}