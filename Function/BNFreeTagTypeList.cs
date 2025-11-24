using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeTagTypeList(BNTagType** tagTypes, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreeTagTypeList"
        )]
		internal static extern void BNFreeTagTypeList(
			
			// BNTagType** tagTypes
		    IntPtr tagTypes  , 
			
			// uint64_t count
		    ulong count  
		);
	}
}