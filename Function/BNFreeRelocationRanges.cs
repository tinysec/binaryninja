using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeRelocationRanges(BNRange* ranges)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreeRelocationRanges"
        )]
		internal static extern void BNFreeRelocationRanges(
			
			// BNRange* ranges
		    IntPtr ranges  
		);
	}
}