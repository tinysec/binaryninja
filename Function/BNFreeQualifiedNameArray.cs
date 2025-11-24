using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeQualifiedNameArray(BNQualifiedName* names, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeQualifiedNameArray"
        )]
		internal static extern void BNFreeQualifiedNameArray(
			
			// BNQualifiedName* names
		    IntPtr names  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}