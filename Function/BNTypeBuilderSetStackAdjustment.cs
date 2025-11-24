using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNTypeBuilderSetStackAdjustment(BNTypeBuilder* type, BNOffsetWithConfidence* adjust)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNTypeBuilderSetStackAdjustment"
        )]
		internal static extern void BNTypeBuilderSetStackAdjustment(
			
			// BNTypeBuilder* type
		    IntPtr type  , 
			
			// BNOffsetWithConfidence* adjust
		    in BNOffsetWithConfidence adjust  
		);
	}
}