using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint8_t* BNMetadataGetRaw(BNMetadata* data, uint64_t* size)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNMetadataGetRaw"
        )]
		internal static extern IntPtr BNMetadataGetRaw(
			
			// BNMetadata* data
		    IntPtr data  , 
			
			// uint64_t* size
		    out ulong size  
		);
	}
}