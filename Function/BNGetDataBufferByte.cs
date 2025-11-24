using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint8_t BNGetDataBufferByte(BNDataBuffer* buf, uint64_t offset)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetDataBufferByte"
        )]
		internal static extern byte BNGetDataBufferByte(
			
			// BNDataBuffer* buf
		    IntPtr buf  , 
			
			// uint64_t offset
		    ulong offset  
			
		);
	}
}