using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetBinaryReaderVirtualBase(BNBinaryReader* stream, uint64_t @base)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetBinaryReaderVirtualBase"
        )]
		internal static extern void BNSetBinaryReaderVirtualBase(
			
			// BNBinaryReader* stream
		    IntPtr stream  , 
			
			// uint64_t _base
		    ulong _base  
		);
	}
}