using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeSymbolRawBytes(void* bytes)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreeSymbolRawBytes"
        )]
		internal static extern void BNFreeSymbolRawBytes(
			
			// void* bytes
		    IntPtr bytes  
		);
	}
}