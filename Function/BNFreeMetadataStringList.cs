using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeMetadataStringList(const char** param1, uint64_t param2)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreeMetadataStringList"
        )]
		internal static extern void BNFreeMetadataStringList(
			
			// const char** param1
		    IntPtr param1  , 
			
			// uint64_t param2
		    ulong param2  
		);
	}
}