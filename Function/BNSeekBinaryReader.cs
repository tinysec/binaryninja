using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSeekBinaryReader(BNBinaryReader* stream, uint64_t offset)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSeekBinaryReader"
        )]
		internal static extern void BNSeekBinaryReader(
			
			// BNBinaryReader* stream
		    IntPtr stream  , 
			
			// uint64_t offset
		    ulong offset  
		);
	}
}