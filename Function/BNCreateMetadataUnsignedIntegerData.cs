using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNMetadata* BNCreateMetadataUnsignedIntegerData(uint64_t data)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreateMetadataUnsignedIntegerData"
        )]
		internal static extern IntPtr BNCreateMetadataUnsignedIntegerData(
			
			// uint64_t data
		    ulong data  
		);
	}
}