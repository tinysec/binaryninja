using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRemoteProject* BNRemoteFolderGetProject(BNRemoteFolder* folder)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRemoteFolderGetProject"
        )]
		internal static extern IntPtr BNRemoteFolderGetProject(
			
			// BNRemoteFolder* folder
		    IntPtr folder  
			
		);
	}
}