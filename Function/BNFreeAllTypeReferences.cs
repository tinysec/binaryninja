using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeAllTypeReferences(BNAllTypeReferences* refs)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeAllTypeReferences"
        )]
		internal static extern void BNFreeAllTypeReferences(
			
			// BNAllTypeReferences* refs
		    IntPtr refs  
			
		);
	}
}