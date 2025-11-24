using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNMetadata** BNMetadataGetArray(BNMetadata* data, uint64_t* size)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNMetadataGetArray"
        )]
		internal static extern IntPtr BNMetadataGetArray(
			
			// BNMetadata* data
		    IntPtr data  , 
			
			// uint64_t* size
		    out ulong size  
		);
	}
}