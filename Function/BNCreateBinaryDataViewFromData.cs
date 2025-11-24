using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNBinaryView* BNCreateBinaryDataViewFromData(BNFileMetadata* file, void* data, uint64_t len)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreateBinaryDataViewFromData"
        )]
		internal static extern IntPtr BNCreateBinaryDataViewFromData(
			
			// BNFileMetadata* file
		    IntPtr file  , 
			
			// void* data
		    byte[] data  , 
			
			// uint64_t len
		    ulong len  
		);
	}
}