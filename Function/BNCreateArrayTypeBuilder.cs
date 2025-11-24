using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNTypeBuilder* BNCreateArrayTypeBuilder(BNTypeWithConfidence* type, uint64_t elem)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreateArrayTypeBuilder"
        )]
		internal static extern IntPtr BNCreateArrayTypeBuilder(
			
			// BNTypeWithConfidence* type
			in BNTypeWithConfidence type  , 
			
			// uint64_t elem
		    ulong elem  
		);
	}
}