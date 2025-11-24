using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNEnumeration* BNNewEnumerationReference(BNEnumeration* e)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNNewEnumerationReference"
        )]
		internal static extern IntPtr BNNewEnumerationReference(
			
			// BNEnumeration* e
		    IntPtr e  
			
		);
	}
}