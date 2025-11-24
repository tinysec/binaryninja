using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetTypeBuilderPointerSuffix(BNTypeBuilder* type, BNPointerSuffix* suffix, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetTypeBuilderPointerSuffix"
        )]
		internal static extern void BNSetTypeBuilderPointerSuffix(
			
			// BNTypeBuilder* type
		    IntPtr type  , 
			
			// BNPointerSuffix* suffix
			PointerSuffix[] suffix  , 
			
			// uint64_t count
		    ulong count  
		);
	}
}