using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRemoteFolder* BNNewRemoteFolderReference(BNRemoteFolder* folder)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNNewRemoteFolderReference"
        )]
		internal static extern IntPtr BNNewRemoteFolderReference(
			
			// BNRemoteFolder* folder
		    IntPtr folder  
			
		);
	}
}