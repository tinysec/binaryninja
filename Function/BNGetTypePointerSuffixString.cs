using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	
	
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// char* BNGetTypePointerSuffixString(BNType* type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetTypePointerSuffixString"
        )]
		internal static extern IntPtr BNGetTypePointerSuffixString(
			
			// BNType* type
		    IntPtr type  
		);
	}
}