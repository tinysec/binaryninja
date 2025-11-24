using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNOffsetWithConfidence BNGetTypeBuilderStackAdjustment(BNTypeBuilder* type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetTypeBuilderStackAdjustment"
        )]
		internal static extern BNOffsetWithConfidence BNGetTypeBuilderStackAdjustment(
			
			// BNTypeBuilder* type
		    IntPtr type  
		);
	}
}