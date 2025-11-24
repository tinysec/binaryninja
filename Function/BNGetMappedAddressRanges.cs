using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNAddressRange* BNGetMappedAddressRanges(BNBinaryView* view, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetMappedAddressRanges"
        )]
		internal static extern IntPtr BNGetMappedAddressRanges(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}