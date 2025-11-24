using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNTypeBuilderSetVolatile(BNTypeBuilder* type, BNBoolWithConfidence* vltl)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNTypeBuilderSetVolatile"
        )]
		internal static extern void BNTypeBuilderSetVolatile(
			
			// BNTypeBuilder* type
		    IntPtr type  , 
			
			// BNBoolWithConfidence* vltl
		    in BNBoolWithConfidence vltl  
		);
	}
}