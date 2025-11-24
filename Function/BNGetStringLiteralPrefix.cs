using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNGetStringLiteralPrefix(BNStringType type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetStringLiteralPrefix"
        )]
		internal static extern IntPtr BNGetStringLiteralPrefix(
			
			// BNStringType type
		    StringType type  
			
		);
	}
}