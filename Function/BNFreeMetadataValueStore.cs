using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeMetadataValueStore(BNMetadataValueStore* data)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreeMetadataValueStore"
        )]
		internal static extern void BNFreeMetadataValueStore(
			
			// BNMetadataValueStore* data
		    IntPtr data  
		);
	}
}