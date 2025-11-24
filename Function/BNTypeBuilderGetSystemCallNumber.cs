using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint32_t BNTypeBuilderGetSystemCallNumber(BNTypeBuilder* type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNTypeBuilderGetSystemCallNumber"
        )]
		internal static extern uint BNTypeBuilderGetSystemCallNumber(
			
			// BNTypeBuilder* type
		    IntPtr type  
		);
	}
}