using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNGetKeyValueStoreValueSize(BNKeyValueStore* store)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetKeyValueStoreValueSize"
        )]
		internal static extern ulong BNGetKeyValueStoreValueSize(
			
			// BNKeyValueStore* store
		    IntPtr store  
		);
	}
}