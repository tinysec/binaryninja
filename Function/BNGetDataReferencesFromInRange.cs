using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t* BNGetDataReferencesFromInRange(BNBinaryView* view, uint64_t addr, uint64_t len, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetDataReferencesFromInRange"
        )]
		internal static extern IntPtr BNGetDataReferencesFromInRange(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// uint64_t addr
		    ulong addr  , 
			
			// uint64_t len
		    ulong len  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}