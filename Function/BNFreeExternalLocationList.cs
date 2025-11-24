using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeExternalLocationList(BNExternalLocation** locs, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeExternalLocationList"
        )]
		internal static extern void BNFreeExternalLocationList(
			
			// BNExternalLocation** locs
		    IntPtr locs  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}