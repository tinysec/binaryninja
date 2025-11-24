using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint32_t* BNGetArchitectureFlagsRequiredForSemanticFlagGroup(BNArchitecture* arch, uint32_t semGroup, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetArchitectureFlagsRequiredForSemanticFlagGroup"
        )]
		internal static extern IntPtr BNGetArchitectureFlagsRequiredForSemanticFlagGroup(
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// uint32_t semGroup
		    uint semGroup  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}