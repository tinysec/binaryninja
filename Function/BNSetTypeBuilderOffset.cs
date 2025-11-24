using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetTypeBuilderOffset(BNTypeBuilder* type, uint64_t offset)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetTypeBuilderOffset"
        )]
		internal static extern void BNSetTypeBuilderOffset(
			
			// BNTypeBuilder* type
		    IntPtr type  , 
			
			// uint64_t offset
		    ulong offset  
		);
	}
}