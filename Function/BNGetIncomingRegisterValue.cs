using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRegisterValue BNGetIncomingRegisterValue(BNCallingConvention* cc, uint32_t reg, BNFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetIncomingRegisterValue"
        )]
		internal static extern BNRegisterValue BNGetIncomingRegisterValue(
			
			// BNCallingConvention* cc
		    IntPtr cc  , 
			
			// uint32_t reg
		    uint reg  , 
			
			// BNFunction* func
		    IntPtr func  
			
		);
	}
}