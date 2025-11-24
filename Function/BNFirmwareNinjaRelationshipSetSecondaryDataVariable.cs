using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFirmwareNinjaRelationshipSetSecondaryDataVariable(BNFirmwareNinjaRelationship* rel, uint64_t dataVariableAddress)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFirmwareNinjaRelationshipSetSecondaryDataVariable"
        )]
		internal static extern void BNFirmwareNinjaRelationshipSetSecondaryDataVariable(
			
			// BNFirmwareNinjaRelationship* rel
		    IntPtr rel  , 
			
			// uint64_t dataVariableAddress
		    ulong dataVariableAddress  
			
		);
	}
}