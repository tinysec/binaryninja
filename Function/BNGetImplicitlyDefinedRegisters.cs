using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint32_t* BNGetImplicitlyDefinedRegisters(BNCallingConvention* cc, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetImplicitlyDefinedRegisters"
        )]
		internal static extern IntPtr BNGetImplicitlyDefinedRegisters(
			
			// BNCallingConvention* cc
		    IntPtr cc  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}