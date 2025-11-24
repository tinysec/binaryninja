using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNWriteDataForDownloadInstance(BNDownloadInstance* instance, uint8_t* data, uint64_t len)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNWriteDataForDownloadInstance"
        )]
		internal static extern ulong BNWriteDataForDownloadInstance(
			
			// BNDownloadInstance* instance
		    IntPtr instance  , 
			
			// uint8_t* data
		    IntPtr data  , 
			
			// uint64_t len
		    ulong len  
			
		);
	}
}