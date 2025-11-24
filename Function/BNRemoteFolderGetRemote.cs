using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRemote* BNRemoteFolderGetRemote(BNRemoteFolder* folder)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRemoteFolderGetRemote"
        )]
		internal static extern IntPtr BNRemoteFolderGetRemote(
			
			// BNRemoteFolder* folder
		    IntPtr folder  
			
		);
	}
}