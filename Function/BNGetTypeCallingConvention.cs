using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNCallingConventionWithConfidence BNGetTypeCallingConvention(BNType* type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetTypeCallingConvention"
        )]
		internal static extern BNCallingConventionWithConfidence BNGetTypeCallingConvention(
			
			// BNType* type
		    IntPtr type  
		);
	}
}