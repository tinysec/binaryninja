using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeTypeAndNameList(BNQualifiedNameAndType* types, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreeTypeAndNameList"
        )]
		internal static extern void BNFreeTypeAndNameList(
			
			// BNQualifiedNameAndType* types
		    IntPtr types  , 
			
			// uint64_t count
		    ulong count  
		);
	}
}