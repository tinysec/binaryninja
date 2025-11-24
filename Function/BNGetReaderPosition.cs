using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNGetReaderPosition(BNBinaryReader* stream)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetReaderPosition"
        )]
		internal static extern ulong BNGetReaderPosition(
			
			// BNBinaryReader* stream
		    IntPtr stream  
		);
	}
}