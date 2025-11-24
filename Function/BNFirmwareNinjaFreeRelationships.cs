using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFirmwareNinjaFreeRelationships(BNFirmwareNinjaRelationship** relationships, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFirmwareNinjaFreeRelationships"
        )]
		internal static extern void BNFirmwareNinjaFreeRelationships(
			
			// BNFirmwareNinjaRelationship** relationships
		    IntPtr relationships  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}