using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNCallingConventionName BNGetTypeCallingConventionName(BNType* type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetTypeCallingConventionName"
        )]
		internal static extern CallingConventionName BNGetTypeCallingConventionName(
			
			// BNType* type
		    IntPtr type  
			
		);
	}
}