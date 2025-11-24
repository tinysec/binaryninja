using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNEndianness BNGetBinaryReaderEndianness(BNBinaryReader* stream)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetBinaryReaderEndianness"
        )]
		internal static extern Endianness BNGetBinaryReaderEndianness(
			
			// BNBinaryReader* stream
		    IntPtr stream  
		);
	}
}