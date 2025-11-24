using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// char** BNGetKeyValueStoreKeys(BNKeyValueStore* store, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetKeyValueStoreKeys"
        )]
		internal static extern IntPtr BNGetKeyValueStoreKeys(
			
			// BNKeyValueStore* store
		    IntPtr store  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}