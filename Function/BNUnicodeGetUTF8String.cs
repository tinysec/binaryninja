using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNUnicodeGetUTF8String(uint32_t** starts, uint32_t** ends, uint64_t* blockListCounts, uint64_t blockCount, uint8_t* data, uint64_t offset, uint64_t dataLen)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNUnicodeGetUTF8String"
        )]
		internal static extern IntPtr BNUnicodeGetUTF8String(
			
			// uint32_t** starts
		    IntPtr starts  , 
			
			// uint32_t** ends
		    IntPtr ends  , 
			
			// uint64_t* blockListCounts
		    IntPtr blockListCounts  , 
			
			// uint64_t blockCount
		    ulong blockCount  , 
			
			// uint8_t* data
		    IntPtr data  , 
			
			// uint64_t offset
		    ulong offset  , 
			
			// uint64_t dataLen
		    ulong dataLen  
			
		);
	}
}