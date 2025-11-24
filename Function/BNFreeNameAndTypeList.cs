using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeNameAndTypeList(BNNameAndType* nt, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreeNameAndTypeList"
        )]
		internal static extern void BNFreeNameAndTypeList(
			
			// BNNameAndType* nt
		    IntPtr nt  , 
			
			// uint64_t count
		    ulong count  
		);
	}
}