using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNDebugInfoParser* BNNewDebugInfoParserReference(BNDebugInfoParser* parser)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNNewDebugInfoParserReference"
        )]
		internal static extern IntPtr BNNewDebugInfoParserReference(
			
			// BNDebugInfoParser* parser
		    IntPtr parser  
			
		);
	}
}