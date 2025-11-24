using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNEnumeration* BNFinalizeEnumerationBuilder(BNEnumerationBuilder* e)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFinalizeEnumerationBuilder"
        )]
		internal static extern IntPtr BNFinalizeEnumerationBuilder(
			
			// BNEnumerationBuilder* e
		    IntPtr e  
		);
	}
}