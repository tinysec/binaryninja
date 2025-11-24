using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNMetadataType BNMetadataGetType(BNMetadata* data)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNMetadataGetType"
        )]
		internal static extern MetadataType BNMetadataGetType(
			
			// BNMetadata* data
		    IntPtr data  
			
		);
	}
}