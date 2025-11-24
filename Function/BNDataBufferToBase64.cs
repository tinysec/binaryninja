using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// char* BNDataBufferToBase64(BNDataBuffer* buf)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNDataBufferToBase64"
        )]
		internal static extern IntPtr BNDataBufferToBase64(
			
			// BNDataBuffer* buf
		    IntPtr buf  
		);
	}
}