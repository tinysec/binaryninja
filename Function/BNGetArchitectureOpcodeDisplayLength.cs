using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNGetArchitectureOpcodeDisplayLength(BNArchitecture* arch)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetArchitectureOpcodeDisplayLength"
        )]
		internal static extern ulong BNGetArchitectureOpcodeDisplayLength(
			
			// BNArchitecture* arch
		    IntPtr arch  
			
		);
	}
}