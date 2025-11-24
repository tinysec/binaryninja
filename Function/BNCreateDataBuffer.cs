using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNDataBuffer* BNCreateDataBuffer(void* data, uint64_t len)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreateDataBuffer"
        )]
		internal static extern IntPtr BNCreateDataBuffer(
			
			// void* data
		    byte[] data  , 
			
			// uint64_t len
		    ulong len  
		);
	}
}