using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNEndKeyValueStoreNamespace(BNKeyValueStore* store)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNEndKeyValueStoreNamespace"
        )]
		internal static extern void BNEndKeyValueStoreNamespace(
			
			// BNKeyValueStore* store
		    IntPtr store  
		);
	}
}