using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNMetadataValueStore* BNMetadataGetValueStore(BNMetadata* data)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNMetadataGetValueStore"
        )]
		internal static extern IntPtr BNMetadataGetValueStore(
			
			// BNMetadata* data
		    IntPtr data  
		);
	}
}