using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetTypeBuilderPointerBase(BNTypeBuilder* type, BNPointerBaseType baseType, int64_t baseOffset)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetTypeBuilderPointerBase"
        )]
		internal static extern void BNSetTypeBuilderPointerBase(
			
			// BNTypeBuilder* type
		    IntPtr type  , 
			
			// BNPointerBaseType baseType
		    PointerBaseType baseType  , 
			
			// int64_t baseOffset
		    long baseOffset  
		);
	}
}