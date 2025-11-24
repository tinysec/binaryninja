using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// bool BNMetadataIsBoolean(BNMetadata* data)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNMetadataIsBoolean"
        )]
		internal static extern bool BNMetadataIsBoolean(
			
			// BNMetadata* data
		    IntPtr data  
		);
	}
}