using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNMetadata* BNCreateMetadataSignedIntegerListData(int64_t* data, uint64_t size)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreateMetadataSignedIntegerListData"
        )]
		internal static extern IntPtr BNCreateMetadataSignedIntegerListData(
			
			// int64_t* data
		    long[] data  , 
			
			// uint64_t size
		    ulong size  
		);
	}
}