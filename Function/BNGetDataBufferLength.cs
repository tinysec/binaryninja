using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNGetDataBufferLength(BNDataBuffer* buf)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetDataBufferLength"
        )]
		internal static extern ulong BNGetDataBufferLength(
			
			// BNDataBuffer* buf
		    IntPtr buf  
		);
	}
}