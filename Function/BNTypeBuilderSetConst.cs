using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNTypeBuilderSetConst(BNTypeBuilder* type, BNBoolWithConfidence* cnst)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNTypeBuilderSetConst"
        )]
		internal static extern void BNTypeBuilderSetConst(
			
			// BNTypeBuilder* type
		    IntPtr type  , 
			
			// BNBoolWithConfidence* cnst
		    in BNBoolWithConfidence cnst  
		);
	}
}