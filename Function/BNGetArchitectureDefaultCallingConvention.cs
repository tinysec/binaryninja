using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNCallingConvention* BNGetArchitectureDefaultCallingConvention(BNArchitecture* arch)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetArchitectureDefaultCallingConvention"
        )]
		internal static extern IntPtr BNGetArchitectureDefaultCallingConvention(
			
			// BNArchitecture* arch
		    IntPtr arch  
			
		);
	}
}