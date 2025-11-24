using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNEndianness BNGetBinaryWriterEndianness(BNBinaryWriter* stream)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetBinaryWriterEndianness"
        )]
		internal static extern Endianness BNGetBinaryWriterEndianness(
			
			// BNBinaryWriter* stream
		    IntPtr stream  
		);
	}
}