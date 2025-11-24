using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// bool BNFirmwareNinjaRelationshipSecondaryIsDataVariable(BNFirmwareNinjaRelationship* rel)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFirmwareNinjaRelationshipSecondaryIsDataVariable"
        )]
		internal static extern bool BNFirmwareNinjaRelationshipSecondaryIsDataVariable(
			
			// BNFirmwareNinjaRelationship* rel
		    IntPtr rel  
			
		);
	}
}