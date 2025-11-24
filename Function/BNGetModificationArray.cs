using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNGetModificationArray(BNBinaryView* view, uint64_t offset, BNModificationStatus* result, uint64_t len)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetModificationArray"
        )]
		internal static extern ulong BNGetModificationArray(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// uint64_t offset
		    ulong offset  , 
			
			// BNModificationStatus* result
			ModificationStatus[] result  , 
			
			// uint64_t len
		    ulong len  
		);
	}
}