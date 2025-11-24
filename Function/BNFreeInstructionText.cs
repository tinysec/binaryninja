using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeInstructionText(BNInstructionTextToken* tokens, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreeInstructionText"
        )]
		internal static extern void BNFreeInstructionText(
			
			// BNInstructionTextToken* tokens
		    IntPtr tokens  , 
			
			// uint64_t count
		    ulong count  
		);
	}
}