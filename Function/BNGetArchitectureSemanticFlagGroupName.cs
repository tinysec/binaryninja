using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// char* BNGetArchitectureSemanticFlagGroupName(BNArchitecture* arch, uint32_t semGroup)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetArchitectureSemanticFlagGroupName"
        )]
		internal static extern IntPtr BNGetArchitectureSemanticFlagGroupName(
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// uint32_t semGroup
			SemanticFlagGroupIndex semGroup  
		);
	}
}