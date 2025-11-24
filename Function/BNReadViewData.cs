using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNReadViewData(BNBinaryView* view, void* dest, uint64_t offset, uint64_t len)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNReadViewData"
        )]
		internal static extern ulong BNReadViewData(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// void* dest
		    byte[] dest  , 
			
			// uint64_t offset
		    ulong offset  , 
			
			// uint64_t len
		    ulong len  
		);
	}
}