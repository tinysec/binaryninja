using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// bool BNRemoteFolderSetParent(BNRemoteFolder* folder, BNRemoteFolder* parent)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRemoteFolderSetParent"
        )]
		internal static extern bool BNRemoteFolderSetParent(
			
			// BNRemoteFolder* folder
		    IntPtr folder  , 
			
			// BNRemoteFolder* parent
		    IntPtr parent  
			
		);
	}
}