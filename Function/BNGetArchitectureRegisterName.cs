using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// char* BNGetArchitectureRegisterName(BNArchitecture* arch, uint32_t reg)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetArchitectureRegisterName"
        )]
		internal static extern IntPtr BNGetArchitectureRegisterName(
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// uint32_t reg
			RegisterIndex reg  
		);
	}
}