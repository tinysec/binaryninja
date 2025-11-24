using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFirmwareNinjaRelationshipSetPrimaryDataVariable(BNFirmwareNinjaRelationship* rel, uint64_t dataVariableAddress)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFirmwareNinjaRelationshipSetPrimaryDataVariable"
        )]
		internal static extern void BNFirmwareNinjaRelationshipSetPrimaryDataVariable(
			
			// BNFirmwareNinjaRelationship* rel
		    IntPtr rel  , 
			
			// uint64_t dataVariableAddress
		    ulong dataVariableAddress  
			
		);
	}
}