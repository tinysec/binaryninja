using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNGetArchitectureFlagWriteTypeName(BNArchitecture* arch, uint32_t flags)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetArchitectureFlagWriteTypeName"
        )]
		internal static extern IntPtr BNGetArchitectureFlagWriteTypeName(
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// uint32_t flags
		    uint flags  
			
		);
	}
}