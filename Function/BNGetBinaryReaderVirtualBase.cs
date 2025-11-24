using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNGetBinaryReaderVirtualBase(BNBinaryReader* stream)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetBinaryReaderVirtualBase"
        )]
		internal static extern ulong BNGetBinaryReaderVirtualBase(
			
			// BNBinaryReader* stream
		    IntPtr stream  
		);
	}
}