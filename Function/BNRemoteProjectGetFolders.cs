using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRemoteFolder** BNRemoteProjectGetFolders(BNRemoteProject* project, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRemoteProjectGetFolders"
        )]
		internal static extern IntPtr BNRemoteProjectGetFolders(
			
			// BNRemoteProject* project
		    IntPtr project  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}