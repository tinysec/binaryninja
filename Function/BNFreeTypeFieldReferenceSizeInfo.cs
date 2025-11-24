using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeTypeFieldReferenceSizeInfo(BNTypeFieldReferenceSizeInfo* refs, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeTypeFieldReferenceSizeInfo"
        )]
		internal static extern void BNFreeTypeFieldReferenceSizeInfo(
			
			// BNTypeFieldReferenceSizeInfo* refs
		    IntPtr refs  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}