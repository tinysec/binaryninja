using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// char* BNGetArchitectureRegisterStackName(BNArchitecture* arch, uint32_t regStack)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetArchitectureRegisterStackName"
        )]
		internal static extern IntPtr BNGetArchitectureRegisterStackName(
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// uint32_t regStack
			RegisterStackIndex regStack  
		);
	}
}