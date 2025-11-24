using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetBinaryWriterEndianness(BNBinaryWriter* stream, BNEndianness endian)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetBinaryWriterEndianness"
        )]
		internal static extern void BNSetBinaryWriterEndianness(
			
			// BNBinaryWriter* stream
		    IntPtr stream  , 
			
			// BNEndianness endian
		    Endianness endian  
		);
	}
}