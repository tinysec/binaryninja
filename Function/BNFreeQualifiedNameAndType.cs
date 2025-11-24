using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeQualifiedNameAndType(BNQualifiedNameAndType* obj)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreeQualifiedNameAndType"
        )]
		internal static extern void BNFreeQualifiedNameAndType(
			
			// BNQualifiedNameAndType* obj
		    in BNQualifiedNameAndType obj  
		);
	}
}