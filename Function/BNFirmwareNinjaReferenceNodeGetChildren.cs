using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNFirmwareNinjaReferenceNode** BNFirmwareNinjaReferenceNodeGetChildren(BNFirmwareNinjaReferenceNode* parent, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFirmwareNinjaReferenceNodeGetChildren"
        )]
		internal static extern IntPtr BNFirmwareNinjaReferenceNodeGetChildren(
			
			// BNFirmwareNinjaReferenceNode* parent
		    IntPtr parent  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}