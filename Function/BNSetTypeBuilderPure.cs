using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetTypeBuilderPure(BNTypeBuilder* type, BNBoolWithConfidence* pure)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetTypeBuilderPure"
        )]
		internal static extern void BNSetTypeBuilderPure(
			
			// BNTypeBuilder* type
		    IntPtr type  , 
			
			// BNBoolWithConfidence* pure
		    in BNBoolWithConfidence pure  
		);
	}
}