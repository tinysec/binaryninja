using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRegisterStackInfo BNGetArchitectureRegisterStackInfo(BNArchitecture* arch, uint32_t regStack)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetArchitectureRegisterStackInfo"
        )]
		internal static extern BNRegisterStackInfo BNGetArchitectureRegisterStackInfo(
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// uint32_t regStack
		    uint regStack  
			
		);
	}
}