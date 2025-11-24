using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNWriteViewData(BNBinaryView* view, uint64_t offset, void* data, uint64_t len)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNWriteViewData"
        )]
		internal static extern ulong BNWriteViewData(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// uint64_t offset
		    ulong offset  , 
			
			// void* data
		    byte[] data  , 
			
			// uint64_t len
		    ulong len  
		);
	}
}