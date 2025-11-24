using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNArchitecture* BNGetCallingConventionArchitecture(BNCallingConvention* cc)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetCallingConventionArchitecture"
        )]
		internal static extern IntPtr BNGetCallingConventionArchitecture(
			
			// BNCallingConvention* cc
		    IntPtr cc  
			
		);
	}
}