using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNFirmwareNinjaRelationship** BNFirmwareNinjaQueryRelationships(BNFirmwareNinja* fn, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFirmwareNinjaQueryRelationships"
        )]
		internal static extern IntPtr BNFirmwareNinjaQueryRelationships(
			
			// BNFirmwareNinja* fn
		    IntPtr fn  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}