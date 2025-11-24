using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNFirmwareNinjaRelationshipGetDescription(BNFirmwareNinjaRelationship* rel)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFirmwareNinjaRelationshipGetDescription"
        )]
		internal static extern IntPtr BNFirmwareNinjaRelationshipGetDescription(
			
			// BNFirmwareNinjaRelationship* rel
		    IntPtr rel  
			
		);
	}
}