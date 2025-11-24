using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNKeyValueStore* BNCreateKeyValueStoreFromDataBuffer(BNDataBuffer* buffer)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreateKeyValueStoreFromDataBuffer"
        )]
		internal static extern IntPtr BNCreateKeyValueStoreFromDataBuffer(
			
			// BNDataBuffer* buffer
		    IntPtr buffer  
		);
	}
}