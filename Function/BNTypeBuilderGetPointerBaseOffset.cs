using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// int64_t BNTypeBuilderGetPointerBaseOffset(BNTypeBuilder* type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNTypeBuilderGetPointerBaseOffset"
        )]
		internal static extern long BNTypeBuilderGetPointerBaseOffset(
			
			// BNTypeBuilder* type
		    IntPtr type  
		);
	}
}