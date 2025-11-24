using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreePointerSuffixList(BNPointerSuffix* suffix, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreePointerSuffixList"
        )]
		internal static extern void BNFreePointerSuffixList(
			
			// BNPointerSuffix* suffix
		    IntPtr suffix  , 
			
			// uint64_t count
		    ulong count  
		);
	}
}