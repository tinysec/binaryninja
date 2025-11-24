using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNGetArchitectureFlagName(BNArchitecture* arch, uint32_t flag)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetArchitectureFlagName"
        )]
		internal static extern IntPtr BNGetArchitectureFlagName(
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// uint32_t flag
			FlagIndex flag  
		);
	}
}