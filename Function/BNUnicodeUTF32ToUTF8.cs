using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNUnicodeUTF32ToUTF8(uint8_t* utf32)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNUnicodeUTF32ToUTF8"
        )]
		internal static extern IntPtr BNUnicodeUTF32ToUTF8(
			
			// uint8_t* utf32
		    IntPtr utf32  
			
		);
	}
}