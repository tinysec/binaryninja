using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint32_t* BNGetAllArchitectureFlagWriteTypes(BNArchitecture* arch, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetAllArchitectureFlagWriteTypes"
        )]
		internal static extern IntPtr BNGetAllArchitectureFlagWriteTypes(
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}