using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeQualifiedNameTypeAndId(BNQualifiedNameTypeAndId* obj)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeQualifiedNameTypeAndId"
        )]
		internal static extern void BNFreeQualifiedNameTypeAndId(
			
			// BNQualifiedNameTypeAndId* obj
		    IntPtr obj  
			
		);
	}
}