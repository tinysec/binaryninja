using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNMetadata* BNCreateMetadataUnsignedIntegerListData(uint64_t* data, uint64_t size)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreateMetadataUnsignedIntegerListData"
        )]
		internal static extern IntPtr BNCreateMetadataUnsignedIntegerListData(
			
			// uint64_t* data
		    ulong[] data  , 
			
			// uint64_t size
		    ulong size  
		);
	}
}