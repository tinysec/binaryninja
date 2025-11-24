using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNInstructionTextToken* BNGetTypeBuilderTokensBeforeName(BNTypeBuilder* type, BNPlatform* platform, uint8_t baseConfidence, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetTypeBuilderTokensBeforeName"
        )]
		internal static extern IntPtr BNGetTypeBuilderTokensBeforeName(
			
			// BNTypeBuilder* type
		    IntPtr type  , 
			
			// BNPlatform* platform
		    IntPtr platform  , 
			
			// uint8_t baseConfidence
		    byte baseConfidence  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}