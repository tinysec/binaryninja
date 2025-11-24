using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNRemoteFolderGetDescription(BNRemoteFolder* folder)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRemoteFolderGetDescription"
        )]
		internal static extern IntPtr BNRemoteFolderGetDescription(
			
			// BNRemoteFolder* folder
		    IntPtr folder  
			
		);
	}
}