using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNGetStringRefContents(BNStringRef* @ref)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetStringRefContents"
        )]
		internal static extern IntPtr BNGetStringRefContents(
			
			// BNStringRef* _ref
		    IntPtr _ref  
			
		);
	}
}