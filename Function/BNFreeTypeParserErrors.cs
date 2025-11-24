using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeTypeParserErrors(BNTypeParserError* errors, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeTypeParserErrors"
        )]
		internal static extern void BNFreeTypeParserErrors(
			
			// BNTypeParserError* errors
		    IntPtr errors  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}