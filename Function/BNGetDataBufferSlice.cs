using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNDataBuffer* BNGetDataBufferSlice(BNDataBuffer* buf, uint64_t start, uint64_t len)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetDataBufferSlice"
        )]
		internal static extern IntPtr BNGetDataBufferSlice(
			
			// BNDataBuffer* buf
		    IntPtr buf  , 
			
			// uint64_t start
		    ulong start  , 
			
			// uint64_t len
		    ulong len  
			
		);
	}
}