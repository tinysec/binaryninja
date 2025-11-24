using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNGetKeyValueStoreValueStorageSize(BNKeyValueStore* store)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetKeyValueStoreValueStorageSize"
        )]
		internal static extern ulong BNGetKeyValueStoreValueStorageSize(
			
			// BNKeyValueStore* store
		    IntPtr store  
		);
	}
}