using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint32_t BNGetArchitectureLinkRegister(BNArchitecture* arch)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetArchitectureLinkRegister"
        )]
		internal static extern uint BNGetArchitectureLinkRegister(
			
			// BNArchitecture* arch
		    IntPtr arch  
			
		);
	}
}