using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNMetadata* BNCreateMetadataArray(BNMetadata** data, uint64_t size)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreateMetadataArray"
        )]
		internal static extern IntPtr BNCreateMetadataArray(
			
			// BNMetadata** data
		    IntPtr[] data  , 
			
			// uint64_t size
		    ulong size  
		);
	}
}