using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSeekBinaryWriterRelative(BNBinaryWriter* stream, int64_t offset)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSeekBinaryWriterRelative"
        )]
		internal static extern void BNSeekBinaryWriterRelative(
			
			// BNBinaryWriter* stream
		    IntPtr stream  , 
			
			// int64_t offset
		    long offset  
			
		);
	}
}