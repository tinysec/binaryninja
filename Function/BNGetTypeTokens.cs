using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNInstructionTextToken* BNGetTypeTokens(BNType* type, BNPlatform* platform, uint8_t baseConfidence, BNTokenEscapingType escaping, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetTypeTokens"
        )]
		internal static extern IntPtr BNGetTypeTokens(
			
			// BNType* type
		    IntPtr type  , 
			
			// BNPlatform* platform
		    IntPtr platform  , 
			
			// uint8_t baseConfidence
		    byte baseConfidence  , 
			
			// BNTokenEscapingType escaping
		    TokenEscapingType escaping  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}