using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// bool BNMetadataIsUnsignedIntegerList(BNMetadata* data)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNMetadataIsUnsignedIntegerList"
        )]
		internal static extern bool BNMetadataIsUnsignedIntegerList(
			
			// BNMetadata* data
		    IntPtr data  
		);
	}
}