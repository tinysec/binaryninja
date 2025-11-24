using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNMetadata* BNCreateMetadataDoubleData(double data)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreateMetadataDoubleData"
        )]
		internal static extern IntPtr BNCreateMetadataDoubleData(
			
			// double data
		    double data  
		);
	}
}