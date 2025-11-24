using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetDataBufferContents(BNDataBuffer* buf, void* data, uint64_t len)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetDataBufferContents"
        )]
		internal static extern void BNSetDataBufferContents(
			
			// BNDataBuffer* buf
		    IntPtr buf  , 
			
			// void* data
		    byte[] data  , 
			
			// uint64_t len
		    ulong len  
		);
	}
}