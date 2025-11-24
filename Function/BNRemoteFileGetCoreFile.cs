using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNProjectFile* BNRemoteFileGetCoreFile(BNRemoteFile* file)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRemoteFileGetCoreFile"
        )]
		internal static extern IntPtr BNRemoteFileGetCoreFile(
			
			// BNRemoteFile* file
		    IntPtr file  
			
		);
	}
}