using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeAllTypeFieldReferences(BNAllTypeFieldReferences* refs)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeAllTypeFieldReferences"
        )]
		internal static extern void BNFreeAllTypeFieldReferences(
			
			// BNAllTypeFieldReferences* refs
		    IntPtr refs  
			
		);
	}
}