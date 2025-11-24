using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNBoolWithConfidence BNIsTypeBuilderConst(BNTypeBuilder* type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNIsTypeBuilderConst"
        )]
		internal static extern BNBoolWithConfidence BNIsTypeBuilderConst(
			
			// BNTypeBuilder* type
		    IntPtr type  
		);
	}
}