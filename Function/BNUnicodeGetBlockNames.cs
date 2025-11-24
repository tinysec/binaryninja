using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNUnicodeGetBlockNames(const char*** names, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNUnicodeGetBlockNames"
        )]
		internal static extern void BNUnicodeGetBlockNames(
			
			// const char*** names
		    IntPtr names  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}