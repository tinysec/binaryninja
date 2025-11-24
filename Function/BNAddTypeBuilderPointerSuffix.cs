using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNAddTypeBuilderPointerSuffix(BNTypeBuilder* type, BNPointerSuffix ps)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAddTypeBuilderPointerSuffix"
        )]
		internal static extern void BNAddTypeBuilderPointerSuffix(
			
			// BNTypeBuilder* type
		    IntPtr type  , 
			
			// BNPointerSuffix ps
		    PointerSuffix ps  
		);
	}
}