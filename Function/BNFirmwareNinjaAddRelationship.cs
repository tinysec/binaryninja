using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFirmwareNinjaAddRelationship(BNFirmwareNinja* fn, BNFirmwareNinjaRelationship* rel)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFirmwareNinjaAddRelationship"
        )]
		internal static extern void BNFirmwareNinjaAddRelationship(
			
			// BNFirmwareNinja* fn
		    IntPtr fn  , 
			
			// BNFirmwareNinjaRelationship* rel
		    IntPtr rel  
			
		);
	}
}