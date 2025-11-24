using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetBinaryReaderEndianness(BNBinaryReader* stream, BNEndianness endian)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetBinaryReaderEndianness"
        )]
		internal static extern void BNSetBinaryReaderEndianness(
			
			// BNBinaryReader* stream
		    IntPtr stream  , 
			
			// BNEndianness endian
		    Endianness endian  
		);
	}
}