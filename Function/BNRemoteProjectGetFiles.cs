using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRemoteFile** BNRemoteProjectGetFiles(BNRemoteProject* project, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRemoteProjectGetFiles"
        )]
		internal static extern IntPtr BNRemoteProjectGetFiles(
			
			// BNRemoteProject* project
		    IntPtr project  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}