using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSeekBinaryWriter(BNBinaryWriter* stream, uint64_t offset)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSeekBinaryWriter"
        )]
		internal static extern void BNSeekBinaryWriter(
			
			// BNBinaryWriter* stream
		    IntPtr stream  , 
			
			// uint64_t offset
		    ulong offset  
		);
	}
}