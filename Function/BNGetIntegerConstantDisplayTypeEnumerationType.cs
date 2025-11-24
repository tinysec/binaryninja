using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNGetIntegerConstantDisplayTypeEnumerationType(BNFunction* func, BNArchitecture* arch, uint64_t instrAddr, uint64_t value, uint64_t operand)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetIntegerConstantDisplayTypeEnumerationType"
        )]
		internal static extern IntPtr BNGetIntegerConstantDisplayTypeEnumerationType(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// uint64_t instrAddr
		    ulong instrAddr  , 
			
			// uint64_t _value
		    ulong _value  , 
			
			// uint64_t operand
		    ulong operand  
			
		);
	}
}