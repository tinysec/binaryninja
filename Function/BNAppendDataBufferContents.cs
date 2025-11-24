using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNAppendDataBufferContents(BNDataBuffer* dest, void* src, uint64_t len)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAppendDataBufferContents"
        )]
		internal static extern void BNAppendDataBufferContents(
			
			// BNDataBuffer* dest
		    IntPtr dest  , 
			
			// void* src
		    byte[] src  , 
			
			// uint64_t len
		    ulong len  
		);
	}
}