using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint32_t* BNGetModifiedArchitectureRegistersOnWrite(BNArchitecture* arch, uint32_t reg, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetModifiedArchitectureRegistersOnWrite"
        )]
		internal static extern IntPtr BNGetModifiedArchitectureRegistersOnWrite(
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// uint32_t reg
		    uint reg  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}