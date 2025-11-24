using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNEnumerationBuilder* BNCreateEnumerationBuilderFromEnumeration(BNEnumeration* e)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreateEnumerationBuilderFromEnumeration"
        )]
		internal static extern IntPtr BNCreateEnumerationBuilderFromEnumeration(
			
			// BNEnumeration* e
		    IntPtr e  
		);
	}
}