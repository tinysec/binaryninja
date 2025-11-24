using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeProjectList(BNProject** projects, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeProjectList"
        )]
		internal static extern void BNFreeProjectList(
			
			// BNProject** projects
		    IntPtr projects  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}