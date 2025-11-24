using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// int64_t BNReadDataForDownloadInstance(BNDownloadInstance* instance, uint8_t* data, uint64_t len)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNReadDataForDownloadInstance"
        )]
		internal static extern long BNReadDataForDownloadInstance(
			
			// BNDownloadInstance* instance
		    IntPtr instance  , 
			
			// uint8_t* data
		    IntPtr data  , 
			
			// uint64_t len
		    ulong len  
			
		);
	}
}