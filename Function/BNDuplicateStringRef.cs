using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNStringRef* BNDuplicateStringRef(BNStringRef* @ref)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNDuplicateStringRef"
        )]
		internal static extern IntPtr BNDuplicateStringRef(
			
			// BNStringRef* _ref
		    IntPtr _ref  
			
		);
	}
}