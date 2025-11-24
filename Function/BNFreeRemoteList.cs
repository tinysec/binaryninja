using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeRemoteList(BNRemote** remotes, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeRemoteList"
        )]
		internal static extern void BNFreeRemoteList(
			
			// BNRemote** remotes
		    IntPtr remotes  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}