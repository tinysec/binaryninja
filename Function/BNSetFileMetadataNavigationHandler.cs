using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetFileMetadataNavigationHandler(BNFileMetadata* file, BNNavigationHandler* handler)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetFileMetadataNavigationHandler"
        )]
		internal static extern void BNSetFileMetadataNavigationHandler(
			
			// BNFileMetadata* file
		    IntPtr file  , 
			
			// BNNavigationHandler* handler
		    IntPtr handler  
			
		);
	}
}