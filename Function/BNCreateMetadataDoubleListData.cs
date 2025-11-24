using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNMetadata* BNCreateMetadataDoubleListData(double* data, uint64_t size)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreateMetadataDoubleListData"
        )]
		internal static extern IntPtr BNCreateMetadataDoubleListData(
			
			// double* data
		    double[] data  , 
			
			// uint64_t size
		    ulong size  
		);
	}
}