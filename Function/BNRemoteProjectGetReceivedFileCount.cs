using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNRemoteProjectGetReceivedFileCount(BNRemoteProject* project)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRemoteProjectGetReceivedFileCount"
        )]
		internal static extern ulong BNRemoteProjectGetReceivedFileCount(
			
			// BNRemoteProject* project
		    IntPtr project  
			
		);
	}
}