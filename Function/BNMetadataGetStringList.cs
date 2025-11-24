using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// char** BNMetadataGetStringList(BNMetadata* data, uint64_t* param2)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNMetadataGetStringList"
        )]
		internal static extern IntPtr BNMetadataGetStringList(
			
			// BNMetadata* data
		    IntPtr data  , 
			
			// uint64_t* param2
		    out ulong param2  
		);
	}
}