using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNGetDemanglerName(BNDemangler* demangler)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetDemanglerName"
        )]
		internal static extern IntPtr BNGetDemanglerName(
			
			// BNDemangler* demangler
		    IntPtr demangler  
			
		);
	}
}