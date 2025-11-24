using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNNotifyDataWritten(BNBinaryView* view, uint64_t offset, uint64_t len)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNNotifyDataWritten"
        )]
		internal static extern void BNNotifyDataWritten(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// uint64_t offset
		    ulong offset  , 
			
			// uint64_t len
		    ulong len  
		);
	}
}