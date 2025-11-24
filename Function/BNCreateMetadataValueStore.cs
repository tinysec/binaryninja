using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNMetadata* BNCreateMetadataValueStore(const char** keys, BNMetadata** values, uint64_t size)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNCreateMetadataValueStore"
        )]
		internal static extern IntPtr BNCreateMetadataValueStore(
			
			// const char** keys
		    string[] keys  , 
			
			// BNMetadata** values
		    IntPtr[] values  , 
			
			// uint64_t size
		    ulong size  
		);
	}
}