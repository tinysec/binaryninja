using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNUnicodeUTF16ToUTF8(uint8_t* utf16, uint64_t len)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNUnicodeUTF16ToUTF8"
        )]
		internal static extern IntPtr BNUnicodeUTF16ToUTF8(
			
			// uint8_t* utf16
		    IntPtr utf16  , 
			
			// uint64_t len
		    ulong len  
			
		);
	}
}