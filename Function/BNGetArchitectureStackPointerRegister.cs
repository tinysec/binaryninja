using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint32_t BNGetArchitectureStackPointerRegister(BNArchitecture* arch)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetArchitectureStackPointerRegister"
        )]
		internal static extern uint BNGetArchitectureStackPointerRegister(
			
			// BNArchitecture* arch
		    IntPtr arch  
		);
	}
}