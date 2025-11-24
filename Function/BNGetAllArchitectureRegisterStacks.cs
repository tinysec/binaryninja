using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint32_t* BNGetAllArchitectureRegisterStacks(BNArchitecture* arch, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetAllArchitectureRegisterStacks"
        )]
		internal static extern IntPtr BNGetAllArchitectureRegisterStacks(
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}