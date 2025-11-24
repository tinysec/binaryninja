using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNFirmwareNinjaRelationship* BNCreateFirmwareNinjaRelationship(BNBinaryView* view)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreateFirmwareNinjaRelationship"
        )]
		internal static extern IntPtr BNCreateFirmwareNinjaRelationship(
			
			// BNBinaryView* view
		    IntPtr view  
		);
	}
}