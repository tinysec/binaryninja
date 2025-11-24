using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeTypeAttributeList(BNTypeAttribute* attr, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeTypeAttributeList"
        )]
		internal static extern void BNFreeTypeAttributeList(
			
			// BNTypeAttribute* attr
		    IntPtr attr  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}