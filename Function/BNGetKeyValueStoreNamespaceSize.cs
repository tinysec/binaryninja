using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNGetKeyValueStoreNamespaceSize(BNKeyValueStore* store)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetKeyValueStoreNamespaceSize"
        )]
		internal static extern ulong BNGetKeyValueStoreNamespaceSize(
			
			// BNKeyValueStore* store
		    IntPtr store  
		);
	}
}