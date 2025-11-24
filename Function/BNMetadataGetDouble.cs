using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// double BNMetadataGetDouble(BNMetadata* data)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNMetadataGetDouble"
        )]
		internal static extern double BNMetadataGetDouble(
			
			// BNMetadata* data
		    IntPtr data  
		);
	}
}