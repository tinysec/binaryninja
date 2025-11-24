using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNDataBuffer* BNLzmaDecompress(BNDataBuffer* buf)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNLzmaDecompress"
        )]
		internal static extern IntPtr BNLzmaDecompress(
			
			// BNDataBuffer* buf
		    IntPtr buf  
			
		);
	}
}