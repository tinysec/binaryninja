using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeStringList(const char** strs, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreeStringList"
        )]
		internal static extern void BNFreeStringList(
			
			// const char** strs
		    IntPtr strs  , 
			
			// uint64_t count
		    ulong count  
		);
	}
}