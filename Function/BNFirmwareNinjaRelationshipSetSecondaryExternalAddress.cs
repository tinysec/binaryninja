using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFirmwareNinjaRelationshipSetSecondaryExternalAddress(BNFirmwareNinjaRelationship* rel, BNProjectFile* projectFile, uint64_t address)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFirmwareNinjaRelationshipSetSecondaryExternalAddress"
        )]
		internal static extern void BNFirmwareNinjaRelationshipSetSecondaryExternalAddress(
			
			// BNFirmwareNinjaRelationship* rel
		    IntPtr rel  , 
			
			// BNProjectFile* projectFile
		    IntPtr projectFile  , 
			
			// uint64_t address
		    ulong address  
			
		);
	}
}