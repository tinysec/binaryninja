using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFirmwareNinjaRelationshipSetSecondaryFunction(BNFirmwareNinjaRelationship* rel, BNFunction* function)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFirmwareNinjaRelationshipSetSecondaryFunction"
        )]
		internal static extern void BNFirmwareNinjaRelationshipSetSecondaryFunction(
			
			// BNFirmwareNinjaRelationship* rel
		    IntPtr rel  , 
			
			// BNFunction* function
		    IntPtr function  
			
		);
	}
}