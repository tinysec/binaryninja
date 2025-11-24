using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNTypeBuilderSetSystemCallNumber(BNTypeBuilder* type, bool v, uint32_t n)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNTypeBuilderSetSystemCallNumber"
        )]
		internal static extern void BNTypeBuilderSetSystemCallNumber(
			
			// BNTypeBuilder* type
		    IntPtr type  , 
			
			// bool v
		    bool v  , 
			
			// uint32_t n
		    uint n  
		);
	}
}