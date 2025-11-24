using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRemoteProject* BNRemoteFileGetProject(BNRemoteFile* file)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRemoteFileGetProject"
        )]
		internal static extern IntPtr BNRemoteFileGetProject(
			
			// BNRemoteFile* file
		    IntPtr file  
			
		);
	}
}