using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeDebugInfoParserList(BNDebugInfoParser** parsers, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeDebugInfoParserList"
        )]
		internal static extern void BNFreeDebugInfoParserList(
			
			// BNDebugInfoParser** parsers
		    IntPtr parsers  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}