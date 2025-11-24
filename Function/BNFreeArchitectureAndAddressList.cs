using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeArchitectureAndAddressList(BNArchitectureAndAddress* addresses)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreeArchitectureAndAddressList"
        )]
		internal static extern void BNFreeArchitectureAndAddressList(
			
			// BNArchitectureAndAddress* addresses
		    IntPtr addresses  
		);
	}
}