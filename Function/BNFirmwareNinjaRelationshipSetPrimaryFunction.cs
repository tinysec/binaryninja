using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFirmwareNinjaRelationshipSetPrimaryFunction(BNFirmwareNinjaRelationship* rel, BNFunction* function)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFirmwareNinjaRelationshipSetPrimaryFunction"
        )]
		internal static extern void BNFirmwareNinjaRelationshipSetPrimaryFunction(
			
			// BNFirmwareNinjaRelationship* rel
		    IntPtr rel  , 
			
			// BNFunction* function
		    IntPtr function  
			
		);
	}
}