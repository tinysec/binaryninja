using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNMetadataGetUnsignedInteger(BNMetadata* data)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNMetadataGetUnsignedInteger"
        )]
		internal static extern ulong BNMetadataGetUnsignedInteger(
			
			// BNMetadata* data
		    IntPtr data  
		);
	}
}