using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRegisterInfo BNGetArchitectureRegisterInfo(BNArchitecture* arch, uint32_t reg)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetArchitectureRegisterInfo"
        )]
		internal static extern BNRegisterInfo BNGetArchitectureRegisterInfo(
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// uint32_t reg
			RegisterIndex reg  
		);
	}
}