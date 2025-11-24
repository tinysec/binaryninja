using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeFirmwareNinjaReferenceNodes(BNFirmwareNinjaReferenceNode** nodes, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeFirmwareNinjaReferenceNodes"
        )]
		internal static extern void BNFreeFirmwareNinjaReferenceNodes(
			
			// BNFirmwareNinjaReferenceNode** nodes
		    IntPtr nodes  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}