using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeRemoteProjectList(BNRemoteProject** projects, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeRemoteProjectList"
        )]
		internal static extern void BNFreeRemoteProjectList(
			
			// BNRemoteProject** projects
		    IntPtr projects  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}