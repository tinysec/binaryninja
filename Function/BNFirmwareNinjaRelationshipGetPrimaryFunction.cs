using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNFunction* BNFirmwareNinjaRelationshipGetPrimaryFunction(BNFirmwareNinjaRelationship* rel)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFirmwareNinjaRelationshipGetPrimaryFunction"
        )]
		internal static extern IntPtr BNFirmwareNinjaRelationshipGetPrimaryFunction(
			
			// BNFirmwareNinjaRelationship* rel
		    IntPtr rel  
			
		);
	}
}