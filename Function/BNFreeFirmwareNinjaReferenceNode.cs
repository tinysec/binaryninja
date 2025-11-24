using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeFirmwareNinjaReferenceNode(BNFirmwareNinjaReferenceNode* node)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeFirmwareNinjaReferenceNode"
        )]
		internal static extern void BNFreeFirmwareNinjaReferenceNode(
			
			// BNFirmwareNinjaReferenceNode* node
		    IntPtr node  
			
		);
	}
}