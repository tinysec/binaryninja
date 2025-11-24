using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeLineFormatterList(BNLineFormatter** formatters)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeLineFormatterList"
        )]
		internal static extern void BNFreeLineFormatterList(
			
			// BNLineFormatter** formatters
		    IntPtr formatters  
			
		);
	}
}