using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeDebugInfoReference(BNDebugInfo* debugInfo)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeDebugInfoReference"
        )]
		internal static extern void BNFreeDebugInfoReference(
			
			// BNDebugInfo* debugInfo
		    IntPtr debugInfo  
			
		);
	}
}