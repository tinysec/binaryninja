using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSeekBinaryReaderRelative(BNBinaryReader* stream, int64_t offset)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSeekBinaryReaderRelative"
        )]
		internal static extern void BNSeekBinaryReaderRelative(
			
			// BNBinaryReader* stream
		    IntPtr stream  , 
			
			// int64_t offset
		    long offset  
			
		);
	}
}