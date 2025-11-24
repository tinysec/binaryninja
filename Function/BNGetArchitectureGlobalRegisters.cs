using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint32_t* BNGetArchitectureGlobalRegisters(BNArchitecture* arch, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetArchitectureGlobalRegisters"
        )]
		internal static extern IntPtr BNGetArchitectureGlobalRegisters(
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}