using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNEnumerationBuilder* BNDuplicateEnumerationBuilder(BNEnumerationBuilder* e)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNDuplicateEnumerationBuilder"
        )]
		internal static extern IntPtr BNDuplicateEnumerationBuilder(
			
			// BNEnumerationBuilder* e
		    IntPtr e  
			
		);
	}
}