using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNTypeBuilderSetChildType(BNTypeBuilder* type, BNTypeWithConfidence* child)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNTypeBuilderSetChildType"
        )]
		internal static extern void BNTypeBuilderSetChildType(
			
			// BNTypeBuilder* type
		    IntPtr type  , 
			
			// BNTypeWithConfidence* child
		    in BNTypeWithConfidence child  
		);
	}
}