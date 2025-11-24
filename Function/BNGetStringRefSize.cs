using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNGetStringRefSize(BNStringRef* @ref)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetStringRefSize"
        )]
		internal static extern ulong BNGetStringRefSize(
			
			// BNStringRef* _ref
		    IntPtr _ref  
			
		);
	}
}