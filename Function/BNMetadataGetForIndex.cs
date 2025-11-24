using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNMetadata* BNMetadataGetForIndex(BNMetadata* data, uint64_t index)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNMetadataGetForIndex"
        )]
		internal static extern IntPtr BNMetadataGetForIndex(
			
			// BNMetadata* data
		    IntPtr data  , 
			
			// uint64_t index
		    ulong index  
		);
	}
}