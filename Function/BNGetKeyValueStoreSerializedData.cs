using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNDataBuffer* BNGetKeyValueStoreSerializedData(BNKeyValueStore* store)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetKeyValueStoreSerializedData"
        )]
		internal static extern IntPtr BNGetKeyValueStoreSerializedData(
			
			// BNKeyValueStore* store
		    IntPtr store  
			
		);
	}
}