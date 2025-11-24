using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNInstructionTextToken* BNGetTypeBuilderPointerSuffixTokens(BNTypeBuilder* type, uint8_t baseConfidence, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetTypeBuilderPointerSuffixTokens"
        )]
		internal static extern IntPtr BNGetTypeBuilderPointerSuffixTokens(
			
			// BNTypeBuilder* type
		    IntPtr type  , 
			
			// uint8_t baseConfidence
		    byte baseConfidence  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}