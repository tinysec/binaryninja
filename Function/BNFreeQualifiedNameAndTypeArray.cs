using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeQualifiedNameAndTypeArray(BNQualifiedNameAndType* obj, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreeQualifiedNameAndTypeArray"
        )]
		internal static extern void BNFreeQualifiedNameAndTypeArray(
			
			// BNQualifiedNameAndType* obj
		    IntPtr obj  , 
			
			// uint64_t count
		    ulong count  
		);
	}
}