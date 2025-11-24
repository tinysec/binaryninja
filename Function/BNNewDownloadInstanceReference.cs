using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNDownloadInstance* BNNewDownloadInstanceReference(BNDownloadInstance* instance)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNNewDownloadInstanceReference"
        )]
		internal static extern IntPtr BNNewDownloadInstanceReference(
			
			// BNDownloadInstance* instance
		    IntPtr instance  
			
		);
	}
}