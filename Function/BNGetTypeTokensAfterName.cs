using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNInstructionTextToken* BNGetTypeTokensAfterName(BNType* type, BNPlatform* platform, uint8_t baseConfidence, BNTokenEscapingType escaping, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetTypeTokensAfterName"
        )]
		internal static extern IntPtr BNGetTypeTokensAfterName(
			
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