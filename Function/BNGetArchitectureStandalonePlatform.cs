using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNPlatform* BNGetArchitectureStandalonePlatform(BNArchitecture* arch)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetArchitectureStandalonePlatform"
        )]
		internal static extern IntPtr BNGetArchitectureStandalonePlatform(
			
			// BNArchitecture* arch
		    IntPtr arch  
		);
	}
}