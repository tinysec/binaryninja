using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNTypeBuilderSetWidth(BNTypeBuilder* type, uint64_t width)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNTypeBuilderSetWidth"
        )]
		internal static extern void BNTypeBuilderSetWidth(
			
			// BNTypeBuilder* type
		    IntPtr type  , 
			
			// uint64_t width
		    ulong width  
		);
	}
}