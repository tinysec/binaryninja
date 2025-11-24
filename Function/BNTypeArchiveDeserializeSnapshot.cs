using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNTypeArchiveDeserializeSnapshot(BNTypeArchive* archive, BNDataBuffer* buffer)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNTypeArchiveDeserializeSnapshot"
        )]
		internal static extern IntPtr BNTypeArchiveDeserializeSnapshot(
			
			// BNTypeArchive* archive
		    IntPtr archive  , 
			
			// BNDataBuffer* buffer
		    IntPtr buffer  
			
		);
	}
}