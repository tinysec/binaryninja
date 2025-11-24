using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeUserList(BNUser** users, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeUserList"
        )]
		internal static extern void BNFreeUserList(
			
			// BNUser** users
		    IntPtr users  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}