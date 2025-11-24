using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// bool BNRemoteFileDownload(BNRemoteFile* file, void** progress, void* progressCtxt, uint8_t** data, uint64_t* size)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRemoteFileDownload"
        )]
		internal static extern bool BNRemoteFileDownload(
			
			// BNRemoteFile* file
		    IntPtr file  , 
			
			// void** progress
		    IntPtr progress  , 
			
			// void* progressCtxt
		    IntPtr progressCtxt  , 
			
			// uint8_t** data
		    IntPtr data  , 
			
			// uint64_t* size
		    IntPtr size  
			
		);
	}
}