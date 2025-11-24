using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeMetadataSignedIntegerList(int64_t* param1, uint64_t param2)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreeMetadataSignedIntegerList"
        )]
		internal static extern void BNFreeMetadataSignedIntegerList(
			
			// int64_t* param1
		    IntPtr param1  , 
			
			// uint64_t param2
		    ulong param2  
		);
	}
}