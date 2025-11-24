using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNGetNextValidOffset(BNBinaryView* view, uint64_t offset)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetNextValidOffset"
        )]
		internal static extern ulong BNGetNextValidOffset(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// uint64_t offset
		    ulong offset  
		);
	}
}