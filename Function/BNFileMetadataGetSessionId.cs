using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNFileMetadataGetSessionId(BNFileMetadata* file)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFileMetadataGetSessionId"
        )]
		internal static extern ulong BNFileMetadataGetSessionId(
			
			// BNFileMetadata* file
		    IntPtr file  
		);
	}
}