using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint32_t BNGetHighIntegerReturnValueRegister(BNCallingConvention* cc)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetHighIntegerReturnValueRegister"
        )]
		internal static extern uint BNGetHighIntegerReturnValueRegister(
			
			// BNCallingConvention* cc
		    IntPtr cc  
			
		);
	}
}