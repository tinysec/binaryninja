using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeTypeParserResult(BNTypeParserResult* result)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreeTypeParserResult"
        )]
		internal static extern void BNFreeTypeParserResult(
			
			// BNTypeParserResult* result
		    in BNTypeParserResult result  
		);
	}
}