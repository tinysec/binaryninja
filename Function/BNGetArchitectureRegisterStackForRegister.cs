using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint32_t BNGetArchitectureRegisterStackForRegister(BNArchitecture* arch, uint32_t reg)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetArchitectureRegisterStackForRegister"
        )]
		internal static extern uint BNGetArchitectureRegisterStackForRegister(
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// uint32_t reg
		    uint reg  
			
		);
	}
}