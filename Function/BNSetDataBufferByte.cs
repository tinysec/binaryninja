using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetDataBufferByte(BNDataBuffer* buf, uint64_t offset, uint8_t val)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetDataBufferByte"
        )]
		internal static extern void BNSetDataBufferByte(
			
			// BNDataBuffer* buf
		    IntPtr buf  , 
			
			// uint64_t offset
		    ulong offset  , 
			
			// uint8_t val
		    byte val  
			
		);
	}
}