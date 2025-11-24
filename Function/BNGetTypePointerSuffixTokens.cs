using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNInstructionTextToken* BNGetTypePointerSuffixTokens(BNType* type, uint8_t baseConfidence, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetTypePointerSuffixTokens"
        )]
		internal static extern IntPtr BNGetTypePointerSuffixTokens(
			
			// BNType* type
		    IntPtr type  , 
			
			// uint8_t baseConfidence
		    byte baseConfidence  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}