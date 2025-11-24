using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNBinaryView* BNCreateBinaryDataViewFromBuffer(BNFileMetadata* file, BNDataBuffer* buf)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreateBinaryDataViewFromBuffer"
        )]
		internal static extern IntPtr BNCreateBinaryDataViewFromBuffer(
			
			// BNFileMetadata* file
		    IntPtr file  , 
			
			// BNDataBuffer* buf
		    IntPtr buf  
		);
	}
}