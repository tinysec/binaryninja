using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNFirmwareNinjaReferenceNode* BNNewFirmwareNinjaReferenceNodeReference(BNFirmwareNinjaReferenceNode* node)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNNewFirmwareNinjaReferenceNodeReference"
        )]
		internal static extern IntPtr BNNewFirmwareNinjaReferenceNodeReference(
			
			// BNFirmwareNinjaReferenceNode* node
		    IntPtr node  
			
		);
	}
}