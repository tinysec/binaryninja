using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNMetadata* BNCreateMetadataStringListData(const char** data, uint64_t size)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNCreateMetadataStringListData"
        )]
		internal static extern IntPtr BNCreateMetadataStringListData(
			
			// const char** data
		    string[] data  , 
			
			// uint64_t size
		    ulong size  
		);
	}
}