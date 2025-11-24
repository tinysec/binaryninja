using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFinalizeArchitectureHook(BNArchitecture* @base)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFinalizeArchitectureHook"
        )]
		internal static extern void BNFinalizeArchitectureHook(
			
			// BNArchitecture* _base
		    IntPtr _base  
		);
	}
}