using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNArchitecture* BNRegisterArchitectureHook(BNArchitecture* @base, BNCustomArchitecture* arch)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRegisterArchitectureHook"
        )]
		internal static extern IntPtr BNRegisterArchitectureHook(
			
			// BNArchitecture* _base
		    IntPtr _base  , 
			
			// BNCustomArchitecture* arch
		    IntPtr arch  
			
		);
	}
}