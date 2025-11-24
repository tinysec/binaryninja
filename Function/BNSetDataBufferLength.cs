using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetDataBufferLength(BNDataBuffer* buf, uint64_t len)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetDataBufferLength"
        )]
		internal static extern void BNSetDataBufferLength(
			
			// BNDataBuffer* buf
		    IntPtr buf  , 
			
			// uint64_t len
		    ulong len  
			
		);
	}
}