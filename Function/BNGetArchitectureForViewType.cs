using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNArchitecture* BNGetArchitectureForViewType(BNBinaryViewType* type, uint32_t id, BNEndianness endian)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetArchitectureForViewType"
        )]
		internal static extern IntPtr BNGetArchitectureForViewType(
			
			// BNBinaryViewType* type
		    IntPtr type  , 
			
			// uint32_t id
		    uint id  , 
			
			// BNEndianness endian
		    Endianness endian  
		);
	}
}