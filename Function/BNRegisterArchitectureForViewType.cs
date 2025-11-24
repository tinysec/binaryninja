using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNRegisterArchitectureForViewType(BNBinaryViewType* type, uint32_t id, BNEndianness endian, BNArchitecture* arch)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNRegisterArchitectureForViewType"
        )]
		internal static extern void BNRegisterArchitectureForViewType(
			
			// BNBinaryViewType* type
		    IntPtr type  , 
			
			// uint32_t id
		    uint id  , 
			
			// BNEndianness endian
		    Endianness endian  , 
			
			// BNArchitecture* arch
		    IntPtr arch  
		);
	}
}