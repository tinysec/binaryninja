using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNUnicodeGetBlockRanges(const char*** names, uint32_t** rangeStarts, uint32_t** rangeEnds, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNUnicodeGetBlockRanges"
        )]
		internal static extern void BNUnicodeGetBlockRanges(
			
			// const char*** names
		    IntPtr names  , 
			
			// uint32_t** rangeStarts
		    IntPtr rangeStarts  , 
			
			// uint32_t** rangeEnds
		    IntPtr rangeEnds  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}