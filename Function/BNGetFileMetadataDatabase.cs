using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNDatabase* BNGetFileMetadataDatabase(BNFileMetadata* file)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetFileMetadataDatabase"
        )]
		internal static extern IntPtr BNGetFileMetadataDatabase(
			
			// BNFileMetadata* file
		    IntPtr file  
		);
	}
}