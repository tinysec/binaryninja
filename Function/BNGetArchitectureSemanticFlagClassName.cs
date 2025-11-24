using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// char* BNGetArchitectureSemanticFlagClassName(BNArchitecture* arch, uint32_t semClass)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetArchitectureSemanticFlagClassName"
        )]
		internal static extern IntPtr BNGetArchitectureSemanticFlagClassName(
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// uint32_t semClass
			SemanticFlagClassIndex semClass  
		);
	}
}