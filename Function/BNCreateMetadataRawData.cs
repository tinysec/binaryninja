using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNMetadata* BNCreateMetadataRawData(uint8_t* data, uint64_t size)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreateMetadataRawData"
        )]
		internal static extern IntPtr BNCreateMetadataRawData(
			
			// uint8_t* data
		    byte[] data  , 
			
			// uint64_t size
		    ulong size  
		);
	}
}