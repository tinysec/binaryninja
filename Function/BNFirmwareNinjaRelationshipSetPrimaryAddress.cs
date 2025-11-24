using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFirmwareNinjaRelationshipSetPrimaryAddress(BNFirmwareNinjaRelationship* rel, uint64_t address)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFirmwareNinjaRelationshipSetPrimaryAddress"
        )]
		internal static extern void BNFirmwareNinjaRelationshipSetPrimaryAddress(
			
			// BNFirmwareNinjaRelationship* rel
		    IntPtr rel  , 
			
			// uint64_t address
		    ulong address  
			
		);
	}
}