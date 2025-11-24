using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint32_t* BNGetIntegerArgumentRegisters(BNCallingConvention* cc, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetIntegerArgumentRegisters"
        )]
		internal static extern IntPtr BNGetIntegerArgumentRegisters(
			
			// BNCallingConvention* cc
		    IntPtr cc  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}